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
                SetSpecificSubjectComboBox("Writing");
            }
            else if (subject.Equals("Reading"))
            {
                SetSpecificSubjectComboBox("Reading");
                _donationType = DonationTypes.ReadingEducator;
            }
            else
            {
                SetSpecificSubjectComboBox("Math");
                _donationType = DonationTypes.MathEducator;
            }
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            //Set service to have this subject
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            User user = mainWindow.getUser();

            Service service = new Service(user.getName(), user.getEmail());

            service.setServiceType(ServiceTypes.Educator);
            service.setDonationRequest(_donationType);

            user.addService(service);

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

        private void SetSpecificSubjectComboBox(string theKey)
        {

            List<string> subjectList;

            if (theKey.Equals("Writing"))
            {
                subjectList = new List<string>() { "Persuasive", "Research", "Explanatory", "Narrative" };

            }
            else if (theKey.Equals("Reading"))
            {
                subjectList = new List<string>() { "Fiction", "NonFiction" };
            }
            else //If theKey is equal to Math
            {
                subjectList = new List<string>() { "Algebra", "Calculus", "Geometry" };
            }
            SpecificSubjectComboBox.ItemsSource = subjectList;
        }

        private void InitializeComboBoxes()
        {
            var subjectList = new List<string>() { "Math", "Writing", "Reading" };

            SubjectComboBox.ItemsSource = subjectList;

            SetSpecificSubjectComboBox("Math");

        }
    }
}
