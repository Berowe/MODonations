﻿using FirstFloor.ModernUI.Windows.Navigation;
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
        public InformationPage()
        {
            InitializeComponent();
            nextPage.IsEnabled = false;
            List<String> vehicles = new List<String>();
            vehicles.Add("Sedan");
            vehicles.Add("Truck");
            vehicles.Add("SUV");
            vehicles.Add("Compact");
            
            vehicleList.ItemsSource = vehicles;
            vehicleList.SelectedIndex = 0;
        }

        private void nextPage_Click(object sender, RoutedEventArgs e)
        {
            
            IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
            NavigationCommands.GoToPage.Execute("/ThankYou.xaml", target);
        }

        private void capacityBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Process.Start(@"c:\"); @Karan

            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                String[] temp = filename.Split('\\');
                textBlock1.Text = temp[temp.Length - 1];
                nextPage.IsEnabled = true;
            }
        }

        private void startTimeBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void endTimeBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void vehicleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(vehicleList.SelectedItem as String);
            
        }

        private void startTimeBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (startTime.Text == "Start Time")
            {
                startTime.Text = "";
            }
        }

        private void endTimeBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (endTime.Text == "End Time")
            {
                endTime.Text = "";
            }
        }

        private void Paragraph_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (capacity.Text == "Capacity")
            {
                capacity.Text = "";
            }
        }
    }
}
