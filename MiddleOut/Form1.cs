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
    public partial class Form1 : Form
    {
        private MainWindow main;
        public Form1(MainWindow theMain)
        {
            main = theMain;
            InitializeComponent();
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
            Form2 signUpForm = new Form2(this);
            this.Hide();
            
        }

        private void signInSubmit_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
    }
}
