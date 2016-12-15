using System;
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
        /// <summary>
        /// Author: Ameet Toor
        /// The donation type for the education service.
        /// </summary>
        private DonationTypes myDonationType;

        /// <summary>
        /// Author: Ameet Toor
        /// The description of the service.
        /// </summary>
        private string myDescription;

        /// <summary>
        /// Author: Ameet Toor
        /// The constructor that initializes the fields.
        /// </summary>
        public EducatePage()
        {
            InitializeComponent();
            InitializeFields();
            InitializeButtons();
            InitializeComboBoxes();
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Changes myDonationType depending on which subject was chosen. And changes the secondary combobox content depending on the subject chosen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var subject = SubjectComboBox.SelectedItem.ToString();
            if (subject.Equals("Writing"))
            {
                myDonationType = DonationTypes.Writing;
                SetSpecificSubjectComboBox("Writing");
            }
            else if (subject.Equals("Reading"))
            {
                SetSpecificSubjectComboBox("Reading");
                myDonationType = DonationTypes.Reading;
            }
            else
            {
                SetSpecificSubjectComboBox("Math");
                myDonationType = DonationTypes.Math;
            }
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Changes the desciption string to what is selected in the SpecificSubjectComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpecificSubjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SpecificSubjectComboBox.SelectedItem != null)
                myDescription = SpecificSubjectComboBox.SelectedItem.ToString();
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Creates the service and adds the service to the user that is currently logged in.
        /// And directs the page to the Thank you page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            //Set service to have this subject
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            User user = mainWindow.getUser();

            Service service = new Service(user.getName(), user.getEmail());

            service.setServiceType(ServiceTypes.Educator);
            service.setDonationRequest(myDonationType);
            service.setDescription(myDescription);

            user.addService(service);
            ServiceDatabase serviceDatabase = mainWindow.GetServiceDatabase();
            serviceDatabase.createService(ServiceTypes.Educator, myDonationType, user, service);

            //Direct to thank you page 
            IInputElement target = NavigationHelper.FindFrame("ListPage1", this);
            NavigationCommands.GoToPage.Execute("/ThankYou.xaml", target);
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Returns the donationType that is associated with this service.
        /// </summary>
        /// <returns>The donationType associated with this service.</returns>
        public DonationTypes GetChosenSubjectAsDonationType()
        {
            return myDonationType;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Initializes fields.
        /// </summary>
        private void InitializeFields()
        {
            myDonationType = DonationTypes.Math;
            myDescription = string.Empty;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Initializes Buttons as enabled.
        /// </summary>
        private void InitializeButtons()
        {
            ContinueButton.IsEnabled = true;
        }

        /// <summary>
        /// Author: Ameet Toor
        /// Changes the content of the SpecificSubjectComboBox.
        /// </summary>
        /// <param name="theKey">The subject as a string.</param>
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

        /// <summary>
        /// Author: Ameet Toor
        /// Initializes the SubjectComboBox.
        /// </summary>
        private void InitializeComboBoxes()
        {
            var subjectList = new List<string>() { "Math", "Writing", "Reading" };

            SubjectComboBox.ItemsSource = subjectList;

            SetSpecificSubjectComboBox("Math");

        }


    }
}
