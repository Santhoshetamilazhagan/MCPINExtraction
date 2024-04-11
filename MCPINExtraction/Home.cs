using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCPINExtraction
{
    public partial class Home : Form

    {
        private Dictionary<string, List<string>> microcontrollerPinPackages;
        public Home()
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializeMicrocontrollerPinPackages();


        }
        private void InitializeComboBoxes()
        {
            // Populate ComboBox with microcontroller names 
            ComboBoxMicrocontroller.Items.Add("RH850F1K");
            ComboBoxMicrocontroller.Items.Add("CYT2B9_M4");
            ComboBoxMicrocontroller.Items.Add("S32K46");
            ComboBoxMicrocontroller.Items.Add("S32K48");

            ComboBoxMicrocontroller.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            ComboBoxPinPackage.Enabled = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void InitializeMicrocontrollerPinPackages()
        {
            // Initialize pin packages for each microcontroller
            microcontrollerPinPackages = new Dictionary<string, List<string>>
            {
                { "RH850", new List<string> {  "100 pin", "144 pin", "176 pin" } },
                { "CYT2B9", new List<string> { "100 pin", "144 pin", "176 pin" } },
                { "ST32K46", new List<string> { "84 pin", "76 pin", "100 pin", "144 pin" } },
                { "ST32K48", new List<string> { "84 pin", "76 pin", "100 pin", "144 pin" } }
            };
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMicrocontroller = ComboBoxMicrocontroller.SelectedItem as string;
            if (selectedMicrocontroller != null)
            {
                MessageBox.Show("Selected microcontroller: " + selectedMicrocontroller);
                //ComboBoxPinPackage.Items.Clear();
                ComboBoxPinPackage.Items.AddRange(microcontrollerPinPackages[selectedMicrocontroller].ToArray());
                // Perform actions based on the selected microcontroller

                ComboBoxPinPackage.Enabled = true;
            }
            else if (selectedMicrocontroller == null)
            {
                MessageBox.Show("Please select a microcontroller.");
               

            }
            else
            {
                ComboBoxPinPackage.Enabled = false;
            }


        }
    }
}
