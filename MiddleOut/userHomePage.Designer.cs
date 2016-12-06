namespace MiddleOut
{
    partial class userHomePage
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




        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHoldingPanel = new System.Windows.Forms.Panel();
            this.notificationsButton = new System.Windows.Forms.Button();
            this.homePageNamePanel = new System.Windows.Forms.Panel();
            this.homePageLabel = new System.Windows.Forms.Label();
            this.mapsButton = new System.Windows.Forms.Button();
            this.updateServiceButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonHoldingPanel.SuspendLayout();
            this.homePageNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHoldingPanel
            // 
            this.buttonHoldingPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHoldingPanel.Controls.Add(this.notificationsButton);
            this.buttonHoldingPanel.Controls.Add(this.homePageNamePanel);
            this.buttonHoldingPanel.Controls.Add(this.mapsButton);
            this.buttonHoldingPanel.Controls.Add(this.updateServiceButton);
            this.buttonHoldingPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonHoldingPanel.Name = "buttonHoldingPanel";
            this.buttonHoldingPanel.Size = new System.Drawing.Size(280, 752);
            this.buttonHoldingPanel.TabIndex = 0;
            // 
            // notificationsButton
            // 
            this.notificationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.notificationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notificationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsButton.ForeColor = System.Drawing.Color.White;
            this.notificationsButton.Location = new System.Drawing.Point(0, 498);
            this.notificationsButton.Margin = new System.Windows.Forms.Padding(0);
            this.notificationsButton.Name = "notificationsButton";
            this.notificationsButton.Size = new System.Drawing.Size(280, 68);
            this.notificationsButton.TabIndex = 2;
            this.notificationsButton.Text = "Notifications";
            this.notificationsButton.UseVisualStyleBackColor = false;
            // 
            // homePageNamePanel
            // 
            this.homePageNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.homePageNamePanel.Controls.Add(this.homePageLabel);
            this.homePageNamePanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.homePageNamePanel.Location = new System.Drawing.Point(3, 3);
            this.homePageNamePanel.Name = "homePageNamePanel";
            this.homePageNamePanel.Size = new System.Drawing.Size(274, 118);
            this.homePageNamePanel.TabIndex = 1;
            // 
            // homePageLabel
            // 
            this.homePageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homePageLabel.AutoSize = true;
            this.homePageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageLabel.ForeColor = System.Drawing.Color.White;
            this.homePageLabel.Location = new System.Drawing.Point(41, 38);
            this.homePageLabel.Name = "homePageLabel";
            this.homePageLabel.Size = new System.Drawing.Size(194, 37);
            this.homePageLabel.TabIndex = 0;
            this.homePageLabel.Text = "Home Page";
            this.homePageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homePageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // mapsButton
            // 
            this.mapsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.mapsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mapsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapsButton.ForeColor = System.Drawing.Color.White;
            this.mapsButton.Location = new System.Drawing.Point(0, 400);
            this.mapsButton.Margin = new System.Windows.Forms.Padding(0);
            this.mapsButton.Name = "mapsButton";
            this.mapsButton.Size = new System.Drawing.Size(280, 68);
            this.mapsButton.TabIndex = 1;
            this.mapsButton.Text = "Maps";
            this.mapsButton.UseVisualStyleBackColor = false;
            this.mapsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateServiceButton
            // 
            this.updateServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.updateServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateServiceButton.ForeColor = System.Drawing.Color.White;
            this.updateServiceButton.Location = new System.Drawing.Point(0, 297);
            this.updateServiceButton.Margin = new System.Windows.Forms.Padding(0);
            this.updateServiceButton.Name = "updateServiceButton";
            this.updateServiceButton.Size = new System.Drawing.Size(280, 68);
            this.updateServiceButton.TabIndex = 0;
            this.updateServiceButton.Text = "Update Service";
            this.updateServiceButton.UseVisualStyleBackColor = false;
            this.updateServiceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(593, 27);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(181, 67);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // userHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.buttonHoldingPanel);
            this.Name = "userHomePage";
            this.Size = new System.Drawing.Size(792, 752);
            this.buttonHoldingPanel.ResumeLayout(false);
            this.homePageNamePanel.ResumeLayout(false);
            this.homePageNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonHoldingPanel;
        private System.Windows.Forms.Panel homePageNamePanel;
        private System.Windows.Forms.Label homePageLabel;
        private System.Windows.Forms.Button notificationsButton;
        private System.Windows.Forms.Button mapsButton;
        private System.Windows.Forms.Button updateServiceButton;
        private System.Windows.Forms.Button logOutButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
