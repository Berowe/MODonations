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
    /// <summary>
    /// The sign up form for a new user. 
    /// @Author Charlton & Karanbir
    /// </summary>
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

        /// <summary>
        /// Default sign up constructor. Not recommended for use. Use constructor Form2(Form1 theForm, Mainwindow main). Depricating in future iteration. 
        /// @Author Charlton & Karanbir
        /// </summary>
        public Form2()
        {
            InitializeComponent();      
        }

        /// <summary>
        /// Initializes the sign up form. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="theForm"></param>
        /// <param name="main"></param>
        public Form2(Form1 theForm, MainWindow main)
        {
            InitializeComponent();
            this.main = main;
            formOne = theForm;
            this.CenterToScreen();
            this.Show();
            USER_DATABASE = new UserDatabase();
        }

        /// <summary>
        /// Submits imformation to the UserDatabase. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signUpSubmit_Click(object sender, EventArgs e)
        {
            if (myPassword1.Equals(myPassword2))
            {
                this.Close();
                main.Show();
                User toAdd = new User(myName, myPassword1, myEmail, myAddress, myAppartment, myCity, myState, myZip);
                USER_DATABASE.addUser(toAdd);
                UserDatabase.updateDatabase();
                main.setUser(toAdd);
            } else
            {
                errorTextBox.Text = "Passwords don't match!";
            }
        }

        /// <summary>
        /// Brings up the original sign in form. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButtonToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formOne.Show();
        }

        /// <summary>
        /// Captures the name text field. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newEmailBox_TextChanged(object sender, EventArgs e)
        {
            myName = newEmailBox.Text;
        }

        /// <summary>
        /// Captures the Email text field. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox9_TextChanged(object sender, EventArgs e)
        {
            myEmail = maskedTextBox9.Text;
        }

        /// <summary>
        /// Captures the first password text field. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox7_TextChanged(object sender, EventArgs e)
        {
            myPassword1 = maskedTextBox7.Text;
        }

        /// <summary>
        /// Captures the second password text field. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmPasswordOneBox_TextChanged(object sender, EventArgs e)
        {
            myPassword2 = confirmPasswordOneBox.Text;
        }

        /// <summary>
        /// Captures the address text field. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            myAddress = maskedTextBox2.Text;
        }

        /// <summary>
        /// Captures the apartment text field. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            myAppartment = maskedTextBox3.Text;
        }

        /// <summary>
        /// Captures the city text field. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            myCity = maskedTextBox4.Text;
        }

        /// <summary>
        /// Captures the zipcode text field. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            myZip = maskedTextBox1.Text;
        }

        /// <summary>
        /// Captures the state text field. 
        /// @Author Charlton & Karanbir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox5_TextChanged(object sender, EventArgs e)
        {
            myState = maskedTextBox5.Text;
        }
    }
}
