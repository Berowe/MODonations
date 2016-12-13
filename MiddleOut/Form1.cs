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

namespace MiddleOut
{
    public partial class Form1 : Form
    {
        UserDatabase USER_DATABASE;
        ServiceDatabase SERVICE_DATABASE;
        private MainWindow main;
        private string myEmail;
        private string myPassword;

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

        public Form1()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signIn_Click(object sender, EventArgs e)
        {
            
        }

        private void about_Click(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Form2 signUpForm = new Form2(this, main);
            this.Hide();
            
        }

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

        private void emailBox_Leave(object sender, EventArgs e)
        {
            if (emailBox.Text == "")
            {
                emailBox.Text = "Email";
                emailBox.ForeColor = Color.LightGray;
            }
        }
        private void emailBox_Enter(object sender, EventArgs e)
        {
            if (emailBox.Text == "Email")
            {
                emailBox.Text = "";
                emailBox.ForeColor = Color.White;
            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            myEmail = emailBox.Text;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            myPassword = passwordBox.Text;
        }
    }
}
