﻿
namespace MCPINExtraction
{
    partial class Login
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(264, 264);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 27);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(260, 148);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 27);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Username";
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_button.FlatAppearance.BorderSize = 0;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(396, 451);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(131, 39);
            this.Login_button.TabIndex = 14;
            this.Login_button.Text = "LOGIN";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.welcome);
            this.panel2.Location = new System.Drawing.Point(37, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 82);
            this.panel2.TabIndex = 11;
            // 
            // welcome
            // 
            this.welcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(0, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(778, 82);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "WELCOME BACK!";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(223, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(420, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Don\'t Have Account? Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(541, 390);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(102, 17);
            this.CheckBox1.TabIndex = 20;
            this.CheckBox1.Text = "Show Password";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(265, 195);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(331, 30);
            this.txtusername.TabIndex = 22;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(265, 321);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(331, 30);
            this.txtpassword.TabIndex = 23;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(821, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 34);
            this.button2.TabIndex = 24;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 615);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button button2;
    }
}

