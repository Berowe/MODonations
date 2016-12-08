using System;
using System.Windows.Forms;

namespace MiddleOut
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.newEmailBox = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmPasswordOneBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmPasswordTwoBox = new System.Windows.Forms.MaskedTextBox();
            this.signUpSubmit = new System.Windows.Forms.Button();
            this.backButtonToLogin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel3.Controls.Add(this.newEmailBox);
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 46);
            this.panel3.TabIndex = 4;
            // 
            // newEmailBox
            // 
            this.newEmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.newEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newEmailBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmailBox.ForeColor = System.Drawing.Color.White;
            this.newEmailBox.Location = new System.Drawing.Point(23, 14);
            this.newEmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.newEmailBox.Name = "newEmailBox";
            this.newEmailBox.Size = new System.Drawing.Size(219, 20);
            this.newEmailBox.TabIndex = 0;
            this.newEmailBox.Text = "Full Name";
            this.newEmailBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.newEmailBox_MaskInputRejected);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.confirmPasswordOneBox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(11, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 46);
            this.panel2.TabIndex = 3;
            // 
            // confirmPasswordOneBox
            // 
            this.confirmPasswordOneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.confirmPasswordOneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordOneBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordOneBox.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordOneBox.Location = new System.Drawing.Point(23, 11);
            this.confirmPasswordOneBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPasswordOneBox.Name = "confirmPasswordOneBox";
            this.confirmPasswordOneBox.PasswordChar = '•';
            this.confirmPasswordOneBox.Size = new System.Drawing.Size(219, 20);
            this.confirmPasswordOneBox.TabIndex = 0;
            this.confirmPasswordOneBox.Text = "password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.confirmPasswordTwoBox);
            this.panel1.Location = new System.Drawing.Point(2, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 46);
            this.panel1.TabIndex = 4;
            // 
            // confirmPasswordTwoBox
            // 
            this.confirmPasswordTwoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.confirmPasswordTwoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTwoBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTwoBox.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordTwoBox.Location = new System.Drawing.Point(23, 11);
            this.confirmPasswordTwoBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPasswordTwoBox.Name = "confirmPasswordTwoBox";
            this.confirmPasswordTwoBox.PasswordChar = '•';
            this.confirmPasswordTwoBox.Size = new System.Drawing.Size(219, 20);
            this.confirmPasswordTwoBox.TabIndex = 0;
            this.confirmPasswordTwoBox.Text = "password";
            // 
            // signUpSubmit
            // 
            this.signUpSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.signUpSubmit.FlatAppearance.BorderSize = 0;
            this.signUpSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpSubmit.ForeColor = System.Drawing.Color.White;
            this.signUpSubmit.Location = new System.Drawing.Point(338, 413);
            this.signUpSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.signUpSubmit.Name = "signUpSubmit";
            this.signUpSubmit.Size = new System.Drawing.Size(139, 42);
            this.signUpSubmit.TabIndex = 5;
            this.signUpSubmit.Text = "Sign Up";
            this.signUpSubmit.UseVisualStyleBackColor = false;
            this.signUpSubmit.Click += new System.EventHandler(this.signUpSubmit_Click);
            // 
            // backButtonToLogin
            // 
            this.backButtonToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.backButtonToLogin.FlatAppearance.BorderSize = 0;
            this.backButtonToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonToLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtonToLogin.ForeColor = System.Drawing.Color.White;
            this.backButtonToLogin.Location = new System.Drawing.Point(384, 11);
            this.backButtonToLogin.Margin = new System.Windows.Forms.Padding(2);
            this.backButtonToLogin.Name = "backButtonToLogin";
            this.backButtonToLogin.Size = new System.Drawing.Size(93, 36);
            this.backButtonToLogin.TabIndex = 6;
            this.backButtonToLogin.Text = "Back";
            this.backButtonToLogin.UseVisualStyleBackColor = false;
            this.backButtonToLogin.Click += new System.EventHandler(this.backButtonToLogin_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel4.Controls.Add(this.maskedTextBox1);
            this.panel4.Location = new System.Drawing.Point(13, 409);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 46);
            this.panel4.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(23, 14);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.Text = "Zipcode";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel5.Controls.Add(this.maskedTextBox2);
            this.panel5.Location = new System.Drawing.Point(11, 209);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 46);
            this.panel5.TabIndex = 5;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox2.Location = new System.Drawing.Point(23, 14);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox2.TabIndex = 0;
            this.maskedTextBox2.Text = "Address 1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel6.Controls.Add(this.maskedTextBox3);
            this.panel6.Location = new System.Drawing.Point(11, 259);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(323, 46);
            this.panel6.TabIndex = 5;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox3.Location = new System.Drawing.Point(23, 14);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox3.TabIndex = 0;
            this.maskedTextBox3.Text = "Address 2";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel7.Controls.Add(this.maskedTextBox4);
            this.panel7.Location = new System.Drawing.Point(13, 309);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(321, 46);
            this.panel7.TabIndex = 5;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox4.Location = new System.Drawing.Point(23, 14);
            this.maskedTextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox4.TabIndex = 0;
            this.maskedTextBox4.Text = "City";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.maskedTextBox5);
            this.panel8.Location = new System.Drawing.Point(13, 359);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(321, 46);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel9.Controls.Add(this.maskedTextBox6);
            this.panel9.Location = new System.Drawing.Point(2, 50);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(263, 46);
            this.panel9.TabIndex = 5;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox6.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox6.Location = new System.Drawing.Point(23, 14);
            this.maskedTextBox6.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox6.TabIndex = 0;
            this.maskedTextBox6.Text = "john@doe.com";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox5.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox5.Location = new System.Drawing.Point(23, 14);
            this.maskedTextBox5.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox5.TabIndex = 0;
            this.maskedTextBox5.Text = "State";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel10.Controls.Add(this.maskedTextBox7);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(11, 111);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(323, 46);
            this.panel10.TabIndex = 5;
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox7.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox7.Location = new System.Drawing.Point(23, 11);
            this.maskedTextBox7.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.PasswordChar = '•';
            this.maskedTextBox7.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox7.TabIndex = 0;
            this.maskedTextBox7.Text = "password";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel11.Controls.Add(this.maskedTextBox8);
            this.panel11.Location = new System.Drawing.Point(2, 50);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(263, 46);
            this.panel11.TabIndex = 4;
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox8.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox8.Location = new System.Drawing.Point(23, 11);
            this.maskedTextBox8.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.PasswordChar = '•';
            this.maskedTextBox8.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox8.TabIndex = 0;
            this.maskedTextBox8.Text = "password";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel12.Controls.Add(this.maskedTextBox9);
            this.panel12.Location = new System.Drawing.Point(11, 61);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(323, 46);
            this.panel12.TabIndex = 5;
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox9.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox9.Location = new System.Drawing.Point(23, 14);
            this.maskedTextBox9.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBox9.TabIndex = 0;
            this.maskedTextBox9.Text = "Email Address";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(488, 470);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.signUpSubmit);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.backButtonToLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        private void newEmailBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox newEmailBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox confirmPasswordOneBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox confirmPasswordTwoBox;
        private System.Windows.Forms.Button signUpSubmit;
        private System.Windows.Forms.Button backButtonToLogin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
    }
}