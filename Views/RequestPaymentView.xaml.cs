using System.Diagnostics;
using System.Windows;
using ciderpaysample.API;
using ciderpaysample.API.Dto;

namespace ciderpaysample.Views
{
    /// <summary>
    /// RequestPaymentView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RequestPaymentView : Window
    {
        private ICiderpayApi api;

        public RequestPaymentView(CiderBaseInfo baseInfo)
        {
            InitializeComponent();

            txtMemberID.Text = baseInfo.MemberID;
            txtGoodName.Text = "테스트 상품명";
            txtPrice.Text = "2000";
            txtSmsuse.Text = "Y";

            api = new CiderpayApi();
        }

        private async void btnExecute_Click(object sender, RoutedEventArgs e)
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

            var request = new CpRequestPayment() {
                memberID = txtMemberID.Text,
                price = long.Parse(txtPrice.Text),
                goodName = txtGoodName.Text,
                mobile = txtCustomMobile.Text,
                customName = txtCustomName.Text,
                customNo = txtCustomNo.Text,
                email = txtEmail.Text,
                feedbackurl = txtFeedbackurl.Text,
                returnurl = txtReturnurl.Text,
                var1 = txtVar1.Text,
                var2 = txtVar2.Text,
                smsuse = txtSmsuse.Text,
                sellerMemo= txtSellerMemo.Text,
            };
            
            try
            {
                var result = await api.RequestPayment(request);

                if (result != null && result.success)
                    txtResult.Text = "[성공] 결제창 : " + result.payUrl + ", 요청번호 : " + result.payUniqueNo;
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
