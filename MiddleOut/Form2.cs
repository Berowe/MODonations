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
        }

        private void signUpSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void backButtonToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formOne.Show();
        }
    }
}
