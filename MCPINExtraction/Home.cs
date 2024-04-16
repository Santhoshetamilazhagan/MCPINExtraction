using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MCPINExtraction
{
    public partial class Home : Form
    {
        private Dictionary<string, List<string>> microcontrollerPinPackages = new Dictionary<string, List<string>>();


        public Home()
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializeMicrocontrollerPinPackages(); // Initialize the pin packages   dictionary
            InitializeComponents();

        }

        private void InitializeComboBoxes()
        {
            // Populate ComboBox with microcontroller names 
            ComboBoxMicrocontroller.Items.Add("RH850F1K");
            ComboBoxMicrocontroller.Items.Add("CYT2B9_M4");
            ComboBoxMicrocontroller.Items.Add("S32K146");
            ComboBoxMicrocontroller.Items.Add("S32K148");
            ComboBoxPinPackage.Enabled = false;
        }
        private void Home_Load(object sender, EventArgs e)
        {
        }
        private void InitializeMicrocontrollerPinPackages()
        {
            // Add pin packages for each microcontroller
            microcontrollerPinPackages["RH850F1K"] = new List<string> { "100 pins", "144 pins", "176 pins" };
            microcontrollerPinPackages["CYT2B9_M4"] = new List<string> { "60 pins", "80   pins", "100 pins", "144 pins", "176 pins" };
            microcontrollerPinPackages["S32K146"] = new List<string> { "64 pins", "100 pins", "144 pins" };
            microcontrollerPinPackages["S32K148"] = new List<string> { "100 pins", "144 pins", "176 pins" };

        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMicrocontroller = ComboBoxMicrocontroller.SelectedItem as
           string;
            if (selectedMicrocontroller != null)
            {
                // Ensure that the dictionary contains an entry for the selected  microcontroller

                if (microcontrollerPinPackages.TryGetValue(selectedMicrocontroller, out List<string> pinPackages))

                {
                    // Clear previous items in the ComboBox
                    ComboBoxPinPackage.Items.Clear();
                    // Add pin packages for the selected microcontroller
                    ComboBoxPinPackage.Items.AddRange(pinPackages.ToArray());
                    ComboBoxPinPackage.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Pin packages not found for the selected  microcontroller.");

                }
            }
            else
            {
                ComboBoxPinPackage.Enabled = false;
            }
        }
        private void InitializeComponents()
        {
            // Initialize selectButton
            SelectButton = new Button();
            SelectButton.Name = "selectButton"; // Change button name
            SelectButton.Text = "Browse"; // Change button text
            SelectButton.Click += new EventHandler(SelectButton_Click);

            // Initialize filePathTextBox
            Controls.Add(SelectButton);

        }


      

        private void SelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                string selectedFileName = openFileDialog.FileName;
                filePathTextBox.Text = System.IO.Path.GetFileName(selectedFileName); // Display only file name
            }
        }

    }
}
