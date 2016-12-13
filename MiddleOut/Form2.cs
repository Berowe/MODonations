using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleOut
{
    public partial class Form2 : Form
    {
        private Form1 formOne;
        private MainWindow main;
        private UserDatabase USER_DATABASE;
        private string myName;
        private string myEmail;
        private string myPassword1;
        private string myPassword2;
        private string myAddress;
        private string myAppartment;
        private string myCity;
        private string myState;
        private string myZip;

        public Form2()
        {
            InitializeComponent();      
        }

        public Form2(Form1 theForm, MainWindow main)
        {
            InitializeComponent();
            this.main = main;
            formOne = theForm;
            this.CenterToScreen();
            this.Show();
            USER_DATABASE = new UserDatabase();
        }

        private void signUpSubmit_Click(object sender, EventArgs e)
        {
            if (myPassword1.Equals(myPassword2))
            {
                this.Close();
                main.Show();
                User toAdd = new User(myName, myPassword1, myEmail, myAddress, myAppartment, myCity, myState, myZip);
                USER_DATABASE.addUser(toAdd);
                UserDatabase.updateDatabase();
            } else
            {
                errorTextBox.Text = "Passwords don't match!";
            }
        }

        private void backButtonToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formOne.Show();
        }

        private void newEmailBox_TextChanged(object sender, EventArgs e)
        {
            myName = newEmailBox.Text;
        }

        private void maskedTextBox9_TextChanged(object sender, EventArgs e)
        {
            myEmail = maskedTextBox9.Text;
        }

        private void maskedTextBox7_TextChanged(object sender, EventArgs e)
        {
            myPassword1 = maskedTextBox7.Text;
        }

        private void confirmPasswordOneBox_TextChanged(object sender, EventArgs e)
        {
            myPassword2 = confirmPasswordOneBox.Text;
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            myAddress = maskedTextBox2.Text;
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            myAppartment = maskedTextBox3.Text;
        }

        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            myCity = maskedTextBox4.Text;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            myZip = maskedTextBox1.Text;
        }
    }
}
