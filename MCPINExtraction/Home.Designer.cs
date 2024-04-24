
namespace MCPINExtraction
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Download_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Upload_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Generate_button = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ComboBoxPinPackage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxMicrocontroller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 615);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 64);
            this.panel3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(772, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 35);
            this.button2.TabIndex = 25;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.Download_button);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Upload_button);
            this.panel2.Controls.Add(this.Back_button);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Generate_button);
            this.panel2.Controls.Add(this.filePathTextBox);
            this.panel2.Controls.Add(this.SelectButton);
            this.panel2.Controls.Add(this.ComboBoxPinPackage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ComboBoxMicrocontroller);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 553);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Download_button
            // 
            this.Download_button.BackColor = System.Drawing.Color.FloralWhite;
            this.Download_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Download_button.Location = new System.Drawing.Point(560, 358);
            this.Download_button.Name = "Download_button";
            this.Download_button.Size = new System.Drawing.Size(99, 29);
            this.Download_button.TabIndex = 32;
            this.Download_button.Text = "Download";
            this.Download_button.UseVisualStyleBackColor = false;
            this.Download_button.Click += new System.EventHandler(this.Download_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Upload_button
            // 
            this.Upload_button.BackColor = System.Drawing.Color.FloralWhite;
            this.Upload_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_button.Location = new System.Drawing.Point(642, 272);
            this.Upload_button.Name = "Upload_button";
            this.Upload_button.Size = new System.Drawing.Size(99, 29);
            this.Upload_button.TabIndex = 31;
            this.Upload_button.Text = "Upload";
            this.Upload_button.UseVisualStyleBackColor = false;
            this.Upload_button.Click += new System.EventHandler(this.Upload_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.Color.White;
            this.Back_button.Location = new System.Drawing.Point(10, 383);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(60, 29);
            this.Back_button.TabIndex = 27;
            this.Back_button.Text = "BACK";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "User";
            // 
            // Generate_button
            // 
            this.Generate_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Generate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate_button.FlatAppearance.BorderSize = 0;
            this.Generate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate_button.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_button.ForeColor = System.Drawing.Color.White;
            this.Generate_button.Location = new System.Drawing.Point(348, 358);
            this.Generate_button.Name = "Generate_button";
            this.Generate_button.Size = new System.Drawing.Size(138, 29);
            this.Generate_button.TabIndex = 28;
            this.Generate_button.Text = "GENERATE FILE";
            this.Generate_button.UseVisualStyleBackColor = false;
            this.Generate_button.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextBox.Location = new System.Drawing.Point(278, 279);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(342, 24);
            this.filePathTextBox.TabIndex = 6;
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.FloralWhite;
            this.SelectButton.FlatAppearance.BorderSize = 0;
            this.SelectButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectButton.Location = new System.Drawing.Point(155, 274);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(99, 29);
            this.SelectButton.TabIndex = 5;
            this.SelectButton.Text = "Browse";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ComboBoxPinPackage
            // 
            this.ComboBoxPinPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPinPackage.FormattingEnabled = true;
            this.ComboBoxPinPackage.Location = new System.Drawing.Point(393, 210);
            this.ComboBoxPinPackage.Name = "ComboBoxPinPackage";
            this.ComboBoxPinPackage.Size = new System.Drawing.Size(121, 26);
            this.ComboBoxPinPackage.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pin Package";
            // 
            // ComboBoxMicrocontroller
            // 
            this.ComboBoxMicrocontroller.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMicrocontroller.FormattingEnabled = true;
            this.ComboBoxMicrocontroller.Location = new System.Drawing.Point(391, 129);
            this.ComboBoxMicrocontroller.Name = "ComboBoxMicrocontroller";
            this.ComboBoxMicrocontroller.Size = new System.Drawing.Size(121, 26);
            this.ComboBoxMicrocontroller.TabIndex = 2;
            this.ComboBoxMicrocontroller.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Microcontroller";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 615);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ComboBoxMicrocontroller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxPinPackage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Generate_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Upload_button;
        private System.Windows.Forms.Button Download_button;
    }
}