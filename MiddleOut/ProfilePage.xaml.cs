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
            generateReportsOnScreen();
        }
        
        private void generateReportsOnScreen()
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            User user = mainWindow.getUser();
            
            Reports r = new Reports(user.getServices());
            textBlock.Text= r.GetReport();
            Console.WriteLine(r.GetReport());
        }
    }
}
