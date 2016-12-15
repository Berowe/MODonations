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
    /// Interaction logic for ThankYou.xaml
    /// Co-Author: Lovejit Hari, .xaml
    /// Co-Author: Charlton Smith, nextPage_Click
    /// Returns to home screen on nextPage_Click.
    /// </summary>
    public partial class ThankYou : UserControl
    {
        public ThankYou()
        {
            InitializeComponent();
        }

        private void nextPage_Click(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
            NavigationCommands.GoToPage.Execute("/Pages/Home.xaml", target);
        }
    }
}
