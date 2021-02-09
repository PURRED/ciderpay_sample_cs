using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ciderpaysample.Views;

namespace ciderpaysample
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RequestPaymentBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var baseInfo = new CiderBaseInfo(txtMemberID.Text, txtDevID.Text, txtDevToken.Text);

            var win  = new RequestPaymentView(baseInfo);

            win.Show();
        }

        private void RequestMpToken_OnClick(object sender, RoutedEventArgs e)
        {
            var baseInfo = new CiderBaseInfo(txtMemberID.Text, txtDevID.Text, txtDevToken.Text);

            var win = new MpRequestToken(baseInfo);

            win.Show();
        }
    }
}
