using FirstFloor.ModernUI.Windows.Navigation;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiddleOut
{
    /// <summary>
    /// Interaction logic for InformationPage.xaml
    /// </summary>
    public partial class InformationPage : UserControl
    {
        private string _vehicleType;
        private string _capacity;
        private string _startTime;
        private string _stopTime;
        private string _filePath;

        public InformationPage()
        {
            /// Set vehicle field options. @Author Karanbir 
            InitializeComponent();
            nextPage.IsEnabled = false;
            List<String> vehicles = new List<String>();
            vehicles.Add("Sedan");
            vehicles.Add("Truck");
            vehicles.Add("SUV");
            vehicles.Add("Compact");
            
            vehicleList.ItemsSource = vehicles;
            vehicleList.SelectedIndex = 0;
            _vehicleType = string.Empty;
            _capacity = string.Empty;
            _startTime = string.Empty;
            _stopTime = string.Empty;
            _filePath = string.Empty;
        }

        /// <summary>
        /// Direct the user to the next page (Thank you page). 
        /// @Author Ameet and Karanbir
        /// Grabs user from mainwindow, adds driver information and adds service.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextPage_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            User user = mainWindow.getUser();

            //Add driver info to user
            user.addDriver(_vehicleType, _capacity, _startTime, _stopTime, _filePath);

            //Add driving service to user
            Service service = new Service(user.getName(), user.getEmail());

            service.setServiceType(ServiceTypes.Driver);
            service.setDonationRequest(DonationTypes.TransportGoods);
            service.setDescription("Driving goods.");

            user.addService(service);

            ServiceDatabase serviceDatabase = mainWindow.GetServiceDatabase();
            serviceDatabase.createService(ServiceTypes.Driver, DonationTypes.TransportGoods, user, service);

            IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
            NavigationCommands.GoToPage.Execute("/ThankYou.xaml", target);
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Sets the _capacity field to the text in the CapacityTextbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void capacityBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _capacity = new TextRange(capacityBox.Document.ContentStart, capacityBox.Document.ContentEnd).Text;
        }

        /// <summary>
        /// Author: Karanbir Toor
        /// Opens the file browser to let the user choose the file to upload.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Process.Start(@"c:\"); @Karan

            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dialogue = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dialogue.DefaultExt = ".jpg";
            dialogue.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";


            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dialogue.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dialogue.FileName;
                String[] temp = filename.Split('\\');
                textBlock1.Text = temp[temp.Length - 1];
                nextPage.IsEnabled = true;
                _filePath = filename;
            }
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Sets the _startTime field to the text in the startTimeBox text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startTimeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _startTime = new TextRange(startTimeBox.Document.ContentStart, startTimeBox.Document.ContentEnd).Text;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Sets the _stopTime fields to the text in the endTimebox text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endTimeBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _stopTime = new TextRange(endTimeBox.Document.ContentStart, endTimeBox.Document.ContentEnd).Text;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Sets the _vehicleType to the chosen ComboBox selectedItem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vehicleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //_vehicleType = vehicleList.SelectedItem.ToString();
        }

        /// <summary>
        /// Author: Charlton Smith
        /// If startTimeBox is selected the text is changed to empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startTimeBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (startTime.Text == "Start Time")
            {
                startTime.Text = "";
            }
        }

        /// <summary>
        /// Author: Charlton Smith
        /// If endTimeBox is selected the text in changed to empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endTimeBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (endTime.Text == "End Time")
            {
                endTime.Text = "";
            }
        }

        /// <summary>
        /// Author: Charlton Smith
        /// If CapacityTextBox is selected the string inside of the text box is set to empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paragraph_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (capacity.Text == "Capacity")
            {
                capacity.Text = "";
            }
        }

        private void vehicleList_DropDownClosed(object sender, EventArgs e)
        {
            if (vehicleList.SelectedItem.ToString() == "Sedan")//"Sedan")
                vehicleList.SelectedIndex = 0;
            else if (vehicleList.SelectedItem.ToString() == "Truck") //"Truck")
                vehicleList.SelectedIndex = 1;
            else if (vehicleList.SelectedItem.ToString() == "SUV") //== "SUV")
                vehicleList.SelectedIndex = 2; 
            else if (vehicleList.SelectedItem.ToString() == "Compact") //== "Compact")
                vehicleList.SelectedIndex = 3;
        }
    }
}
