﻿namespace Travel_Ease
{
    partial class HotelLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.usrEmail = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.usrPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(411, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usrEmail
            // 
            this.usrEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usrEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usrEmail.Location = new System.Drawing.Point(500, 252);
            this.usrEmail.Name = "usrEmail";
            this.usrEmail.Size = new System.Drawing.Size(300, 34);
            this.usrEmail.TabIndex = 2;
            this.usrEmail.Text = "e.g JohnDoe@gmail.com";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabel1.Location = new System.Drawing.Point(348, 555);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(345, 29);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account? Sign up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // usrPassword
            // 
            this.usrPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.usrPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usrPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usrPassword.Location = new System.Drawing.Point(500, 331);
            this.usrPassword.Name = "usrPassword";
            this.usrPassword.Size = new System.Drawing.Size(300, 34);
            this.usrPassword.TabIndex = 4;
            this.usrPassword.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(277, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "EMAIL:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(276, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "PASSWORD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(266, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(534, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please enter your user credentials to log in!";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginButton.Location = new System.Drawing.Point(342, 456);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(169, 51);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(542, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "GO BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HotelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1042, 608);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usrPassword);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.usrEmail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotelLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Provider Login";
            this.Load += new System.EventHandler(this.HotelLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usrEmail;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox usrPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button button3;
    }
}

