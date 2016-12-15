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
    /// Interaction logic for LogOutPage.xaml
    /// @Co-Author: Lovejit Hari, yesButton_Click
    /// @Co-Author: Charlton Smith, noButton_Click
    /// Logs out of the program, closes the current application, makes sure that
    /// every instance of the application is also shut down and re-opens the log-in form.
    /// Otherwise the no button returns back to the home page.
    /// </summary>
    public partial class LogOutPage : UserControl
    {
        
        public LogOutPage()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
            NavigationCommands.BrowseBack.Execute(null, target);
        }
    }
}
