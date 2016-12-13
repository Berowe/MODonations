using FirstFloor.ModernUI.Windows.Navigation;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MiddleOut
{
    /// <summary>
    /// Author: Ameet Toor
    /// This class decides what needs to be done when a user selects a type of service to create.
    /// </summary>
    public partial class BasicPage1 : UserControl
    {
        /// <summary>
        /// The type of service that the user chooses.
        /// </summary>
        private ServiceTypes _serviceTypes;

        /// <summary>
        /// Constructor that initializes the fields.
        /// </summary>
        public BasicPage1()
        {
            InitializeComponent();
            _serviceTypes = ServiceTypes.Donor;
        }

        /// <summary>
        /// Authors: Ameet Toor, Karanbir Toor
        /// Sets the service type for the service being added and changes the current page to the page that should be displayed after the button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
