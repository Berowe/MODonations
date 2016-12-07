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
        public MainWindow()
        {
            InitializeComponent();
            Form1 login = new Form1();
            login.Show();

            

            Form2 signUp = new Form2();
            signUp.Show();

            

            User karan = new MiddleOut.User("Karan", "notAsCoolAsAmeet@yup.com");
            Console.WriteLine(karan.getName());

            var service = new Service(1, 2);

            var list = new List<Service> {service};

            var report = new Reports(list);

            Console.WriteLine(report.ToString());

            ReviewService review = new ReviewService(4, "the best");


            Console.WriteLine(review.ToString());

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
