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
            //myUser = new User()

        }


    }
}
