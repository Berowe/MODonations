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


        /// <summary>
        /// Constructs a MainWindow and hides it. 
        /// @Author Karanbir and Ameet
        /// </summary>
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
            
        }

        /// <summary>
        /// Sets the User for this session by getting the user from the UserDatabase via his/her email. 
        /// @Author Karanbir
        /// </summary>
        /// <param name="theUsername"></param>
        public void setUsername(string theUsername)
        {
            myUser = USER_DATABASE.getUser(theUsername);
        }

        /// <summary>
        /// Returns the User for this session.
        /// @Author Karanbir
        /// </summary>
        /// <returns></returns>
        public User getUser()
        {
            return myUser;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Returns the ServiceDatabase.
        /// </summary>
        /// <returns>ServiceDatabase</returns>
        public ServiceDatabase GetServiceDatabase()
        {
            return SERVICE_DATABASE;
        }
        /// <summary>
        /// Sets the user for this session. 
        /// @Author Karanbir
        /// </summary>
        /// <param name="theUser"></param>
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
