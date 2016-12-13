using FirstFloor.ModernUI.Windows.Controls;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        private ServiceTypes myServiceType;
        private User myUser;
        UserDatabase USER_DATABASE { get; set;}
        ServiceDatabase SERVICE_DATABASE { get; set; }
        public string test { get; set; }
        public MainWindow()
        {
            
            SERVICE_DATABASE = new ServiceDatabase();
            USER_DATABASE = new UserDatabase();
            this.Hide();
            InitializeComponent();

            Form1 login = new Form1(this);
            login.Show();
            ReviewService review = new ReviewService(4, "the best");

            Console.WriteLine(review.ToString());


            // Karan region
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        public void setUsername(string theUsername)
        {
            myUser = USER_DATABASE.getUser(theUsername);
        }

        public User getUser()
        {
            User temp = myUser;
            return temp;
        }

        public void setUser(User theUser)
        {
            myUser = theUser;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Gets the service type of the Service being added.
        /// </summary>
        /// <returns>The service type of the current Service.</returns>
        public ServiceTypes getServiceType()
        {
            return myServiceType;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Sets the service type of the Service being added.
        /// </summary>
        /// <param name="theServiceType">The current service type.</param>
        public void setServiceType(ServiceTypes theServiceType)
        {
            myServiceType = theServiceType;
        }


    }
}
