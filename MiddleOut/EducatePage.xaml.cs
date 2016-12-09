using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FirstFloor.ModernUI.Windows.Navigation;

namespace MiddleOut
{
    /// <summary>
    /// Interaction logic for EducatePage.xaml
    /// Author: Ameet Toor
    /// </summary>
    public partial class EducatePage : UserControl
    {
        private DonationTypes _donationType;
        //TODO add other subjects to fit user story
        public EducatePage()
        {
            InitializeComponent();
            InitializeFields();
            InitializeButtons();
            InitializeComboBoxes();
        }

        private void SubjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var subject = SubjectComboBox.SelectedItem.ToString();
            if (subject.Equals("Writing"))
            {
                _donationType = DonationTypes.WritingEducator;
            }
            else if (subject.Equals("Reading"))
            {
                _donationType = DonationTypes.ReadingEducator;
            }
            else
            {
                _donationType = DonationTypes.MathEducator;
            }
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            //Set service to have this subject

            //Direct to thank you page 
            IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
            NavigationCommands.GoToPage.Execute("/ThankYou.xaml", target);
        }

        public DonationTypes GetChosenSubjectAsDonationType()
        {
            return _donationType;
        }

        private void InitializeFields()
        {
            _donationType = DonationTypes.MathEducator;
        }

        private void InitializeButtons()
        {
            ContinueButton.IsEnabled = true;
        }

        private void InitializeComboBoxes()
        {
            var subjectList = new List<string>() {"Math", "Reading", "Writing" };
            SubjectComboBox.ItemsSource = subjectList;
            SubjectComboBox.SelectedIndex = 0;
        }
    }
}
