namespace MiddleOut
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.signIn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.signUp = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Location = new System.Drawing.Point(165, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 71);
            this.panel2.TabIndex = 1;
            // 
            // signIn
            // 
            this.signIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.signIn.FlatAppearance.BorderSize = 0;
            this.signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.ForeColor = System.Drawing.Color.White;
            this.signIn.Location = new System.Drawing.Point(165, 542);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(395, 64);
            this.signIn.TabIndex = 2;
            this.signIn.Text = "Sign in";
            this.signIn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.panel3.Controls.Add(this.maskedTextBox2);
            this.panel3.Location = new System.Drawing.Point(165, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 71);
            this.panel3.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(34, 17);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '•';
            this.maskedTextBox1.Size = new System.Drawing.Size(329, 30);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.Text = "password";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox2.Location = new System.Drawing.Point(34, 21);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(329, 30);
            this.maskedTextBox2.TabIndex = 0;
            this.maskedTextBox2.Text = "john@doe.com";
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.signUp.FlatAppearance.BorderSize = 0;
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.ForeColor = System.Drawing.Color.White;
            this.signUp.Location = new System.Drawing.Point(566, 27);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(140, 56);
            this.signUp.TabIndex = 3;
            this.signUp.Text = "Sign up";
            this.signUp.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(732, 723);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button signUp;
    }
}