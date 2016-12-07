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

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 theForm)
        {
            InitializeComponent();
            formOne = theForm;
            this.Show();
        }

        private void signUpSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButtonToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            formOne.Show();
        }
    }
}
