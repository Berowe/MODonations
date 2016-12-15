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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : UserControl
    {
        
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            User user = mainWindow.getUser();

            Reports r = new MiddleOut.Reports(user.getServices());
            textBlock.Text = r.GetReport();

            userBlock.Text = "Name: " + user.getName() + "\n";
            userBlock.Text += "Address: " + user.getAddress() + "\n";
            userBlock.Text += "Email: " + user.getEmail() + "\n";
        }
    }
}
