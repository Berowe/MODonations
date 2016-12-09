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
        private UserDatabase USER_DATABASE;
        public MainWindow()
        {
            this.Hide();
            InitializeComponent();
            Form1 login = new Form1(this);
            login.Show();
            ReviewService review = new ReviewService(4, "the best");

            Console.WriteLine(review.ToString());
            
            // Karan region
            ServiceDatabase serviceDatabase = new ServiceDatabase();
            UserDatabase userDatabase = new UserDatabase();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
