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
    /// Interaction logic for EducatePage.xaml
    /// </summary>
    public partial class EducatePage : UserControl
    {
        private string _subject;
        public EducatePage()
        {
            InitializeComponent();
            InitializeFields();
            InitializeButtons();
            InitializeComboBoxes();
        }

        private void SubjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _subject = SubjectComboBox.SelectedItem.ToString();
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private string GetChosenSubject()
        {
            return _subject;
        }

        private void InitializeFields()
        {
            _subject = "Math";
        }

        private void InitializeButtons()
        {
            ContinueButton.IsEnabled = false;
        }

        private void InitializeComboBoxes()
        {
            var subjectList = new List<string>() {"Math", "Reading", "Writing" };
            SubjectComboBox.ItemsSource = subjectList;
            SubjectComboBox.SelectedIndex = 0;
        }
    }
}
