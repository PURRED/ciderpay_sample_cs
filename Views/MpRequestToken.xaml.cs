using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ciderpaysample.API;
using ciderpaysample.API.Dto;

namespace ciderpaysample.Views
{
    /// <summary>
    /// MpRequestToken.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MpRequestToken : Window
    {
        private ICiderpayApi api;

        public MpRequestToken(CiderBaseInfo baseInfo)
        {
            InitializeComponent();

            txtMemberID.Text = baseInfo.MemberID;
            txtCustomNo.Text = "A00000";
            txtServiceName.Text = "PC방 자리 결제 서비스";
            txtGoodName.Text = "라면 외 5종";
            txtReason.Text = "PC방 자리에서 편하게 결제할 수 있는 서비스 입니다.";

            api = new CiderpayApi();
        }

        private async void BtnExecute_OnClick(object sender, RoutedEventArgs e)
        {
            if (txtMemberID.Text.Length < 4)
            {
                MessageBox.Show("판매자 아이디를 입력해주세요");
                return;
            }

            if (txtCustomMobile.Text.Length < 10)
            {
                MessageBox.Show("고객 핸드폰 번호를 입력해주세요");
                return;
            }

            if (txtServiceName.Text.Length < 1)
            {
                MessageBox.Show("서비스명을 입력해주세요");
                return;
            }

            if (txtDevID.Text.Length < 1)
            {
                MessageBox.Show("개발사 아이디를 입력해주세요");
                return;
            }

            if (txtDevToken.Text.Length < 1)
            {
                MessageBox.Show("개발사 토큰을 입력해주세요");
                return;
            }

            var goodPrice = string.IsNullOrWhiteSpace(txtGoodPrice.Text) ? 0 : long.Parse(txtGoodPrice.Text);

            var request = new CpRequestMpToken()
            {
                memberID = txtMemberID.Text,
                goodName = txtServiceName.Text,
                customMobile = txtCustomMobile.Text,
                customNo = txtCustomNo.Text,
                reason = txtReason.Text,
                oneJustPayGoodName = txtGoodName.Text,
                oneJustPayPrice = goodPrice,
            };

            var devInfo = new CpDevInfo(txtDevID.Text, txtDevToken.Text);

            try
            {
                var result = await api.RequestMpToken(devInfo, request);

                if (result != null && result.success)
                    txtResult.Text = "[성공] 결제창 : " + result.var1;
                else
                {
                    txtResult.Text = "[실패] 요청에 실패했습니다.";
                }
            }
            catch (CiderpayException ex)
            {
                txtResult.Text = "[실패] - " + ex.Error.message;
                Debug.WriteLine(ex.Error);
            }
        }
    }
}
