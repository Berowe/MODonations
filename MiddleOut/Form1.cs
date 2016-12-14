using FirstFloor.ModernUI.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Application = System.Windows.Application;

namespace MiddleOut
{
    /// <summary>
    /// The sign in page for an existing user. 
    /// @Author Karanbir
    /// </summary>
    public partial class Form1 : Form
    {
        UserDatabase USER_DATABASE;
        ServiceDatabase SERVICE_DATABASE;
        private MainWindow main;
        private string myEmail;
        private string myPassword;

        /// <summary>
        /// Constructs a sign in form for an existing user to sign in with. 
        /// @Author Karanbir
        /// </summary>
        /// <param name="theMain"></param>
        public Form1(MainWindow theMain)
        {
            main = theMain;

            InitializeComponent();
            this.CenterToScreen();

            USER_DATABASE = new UserDatabase();
            SERVICE_DATABASE = new ServiceDatabase();
            emailBox.Text = "john@doe.com";
            passwordBox.Text = "password";
        }

        /// <summary>
        /// Promps the user to sign up as a new user by initializing Form2. 
        /// @Author Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signUpButton_Click(object sender, EventArgs e)
        {
            Form2 signUpForm = new Form2(this, main);
            this.Hide();
        }

        /// <summary>
        /// Existing user attempts to sign in. If successful, show the MainWindow. 
        /// @Author Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signInSubmit_Click(object sender, EventArgs e)
        {
            if (USER_DATABASE.verifyUser(emailBox.Text, passwordBox.Text))
            {
                main.Show();
                this.Close();
                main.setUsername(myEmail);
            } else
            {
                errorTextBox.Text = "Invalid E-mail or Password";
            }

        }

        /// <summary>
        /// Sets text to Email so the user knows what to input. 
        /// @Author Charlton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailBox_Leave(object sender, EventArgs e)
        {
            if (emailBox.Text == "")
            {
                emailBox.Text = "Email";
                emailBox.ForeColor = Color.LightGray;
            }
        }

        /// <summary>
        /// Clears the field so the user can type. 
        /// @Author Charlton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailBox_Enter(object sender, EventArgs e)
        {
            if (emailBox.Text == "Email")
            {
                emailBox.Text = "";
                emailBox.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Saves the email entered. 
        /// @Author Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            myEmail = emailBox.Text;
        }

        /// <summary>
        /// Saves the password entered. 
        /// @Author Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            myPassword = passwordBox.Text;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow.Visibility == Visibility.Hidden)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
