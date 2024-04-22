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
using System.IO;

namespace MCPINExtraction
{
    public partial class Home : Form
    {
        private Dictionary<string, List<string>> microcontrollerPinPackages = new Dictionary<string, List<string>>();
        private string selectedFileName;



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
            microcontrollerPinPackages["CYT2B9_M4"] = new List<string> { "60 pins", "80 pins", "100 pins", "144 pins", "176 pins" };
            microcontrollerPinPackages["S32K146"] = new List<string> { "64 pins","100 pins", "144 pins" };
            microcontrollerPinPackages["S32K148"] = new List<string> { "100 pins","144 pins", "176 pins" };

        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMicrocontroller = ComboBoxMicrocontroller.SelectedItem as string;
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
        
            Button SelectButton = new Button();

            SelectButton.Name = "SelectButton"; // Change button name
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

              
                selectedFileName = openFileDialog.FileName;
                filePathTextBox.Text = selectedFileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Login back = new Login();
            back.Show();

        }

       private void panel2_Paint(object sender, PaintEventArgs e)
        {
            label3.Text = UserLogName.Username;
        }

        private void Generate_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFileName))
            {
                MessageBox.Show("Please select a CSV file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(selectedFileName))
            {
                MessageBox.Show("Selected CSV file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string[]> csvData = ReadCsvFile(selectedFileName);

            // Generate C# file
            using (StreamWriter writer = new StreamWriter("GeneratedCsvData.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine();
                writer.WriteLine("namespace GeneratedCsvData");
                writer.WriteLine("{");
                writer.WriteLine("\tpublic static class CsvData");
                writer.WriteLine("\t{");
                writer.WriteLine("\t\tpublic static List<string[]> GetData()");
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\t\treturn new List<string[]>");
                writer.WriteLine("\t\t\t{");

                foreach (string[] row in csvData)
                {
                    writer.Write("\t\t\t\tnew string[] { ");
                    for (int i = 0; i < row.Length; i++)
                    {
                        writer.Write($"\"{row[i]}\"");
                        if (i < row.Length - 1)
                            writer.Write(", ");
                    }
                    writer.WriteLine(" },");
                }

                writer.WriteLine("\t\t\t};");
                writer.WriteLine("\t\t}");
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }

            MessageBox.Show(".cs file generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<string[]> ReadCsvFile(string filePath)
        {
            List<string[]> csvData = new List<string[]>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');
                        csvData.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return csvData;
        }

        
    }
}
    

