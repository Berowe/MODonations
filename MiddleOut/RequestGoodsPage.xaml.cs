using FirstFloor.ModernUI.Windows.Navigation;
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

namespace MiddleOut
{
    /// <summary>
    /// Author: Karanbir Toor 
    /// Interaction logic for RequestGoodsPage.xaml 
    /// </summary>
    public partial class RequestGoodsPage : UserControl
    {
        public RequestGoodsPage()
        {
            InitializeComponent();
            OtherTextBox.Text = "Donation";
        }

        private void OtherTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (OtherTextBox.Text == "")
            {
                OtherTextBox.Text = "Donation";
                //OtherTextBox.ForeColor = Color.LightGray;
            }
        }

        private void OtherTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (OtherTextBox.Text == "Donation")
            {
                OtherTextBox.Text = "";
                //OtherTextBox.ForeColor = Color.White;
            }
        }

        private void nextPage_Click(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
            NavigationCommands.GoToPage.Execute("/ThankYou.xaml", target);
        }
    }
}
