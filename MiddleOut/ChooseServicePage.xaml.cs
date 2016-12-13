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
    /// Interaction logic for BasicPage1.xaml
    /// 
    /// </summary>
    public partial class BasicPage1 : UserControl
    {
        private ServiceTypes _serviceTypes;
        public BasicPage1()
        {
            InitializeComponent();
            _serviceTypes = ServiceTypes.Donor;
        }

        private void nextPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

            if ((bool)DriverRadioButton.IsChecked)
            {
                _serviceTypes = ServiceTypes.Driver;
                mainWindow.setServiceType(_serviceTypes);
                IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
                NavigationCommands.GoToPage.Execute("/Informationpage.xaml", target);
            } else if ((bool)DonateRadioButton.IsChecked)
            {
                _serviceTypes = ServiceTypes.Donor;
                mainWindow.setServiceType(_serviceTypes);
                IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
                NavigationCommands.GoToPage.Execute("/RequestGoodsPage.xaml", target);
            } else if ((bool)EducateRadioButton.IsChecked)
            {
                _serviceTypes = ServiceTypes.Educator;
                mainWindow.setServiceType(_serviceTypes);
                IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
                NavigationCommands.GoToPage.Execute("/EducatePage.xaml", target);
            } else if ((bool)RequestGoodsButton.IsChecked)
            {
                _serviceTypes = ServiceTypes.Requester;
                mainWindow.setServiceType(_serviceTypes);
                IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
                NavigationCommands.GoToPage.Execute("/RequestGoodsPage.xaml", target);
            }
        }
    }
}
