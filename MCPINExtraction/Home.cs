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
        //private List<string> downloadedFiles = new List<string>();



        public Home()
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializeMicrocontrollerPinPackages(); 
            InitializeComponents();
         
        }

        private void InitializeComboBoxes()
        {
            
            ComboBoxMicrocontroller.Items.Add("RH850F1K");
            ComboBoxMicrocontroller.Items.Add("CYT2B9_M4");
            ComboBoxMicrocontroller.Items.Add("S32K146");
            ComboBoxMicrocontroller.Items.Add("S32K148");
            //ComboBoxPinPackage.Enabled = false;
           // SelectButton.Enabled = false;



        }
        private void Home_Load(object sender, EventArgs e)
        {
           
        }
        private void InitializeMicrocontrollerPinPackages()
        {
            
            microcontrollerPinPackages["RH850F1K"] = new List<string> { "100 pins", "144 pins", "176 pins" };
            microcontrollerPinPackages["CYT2B9_M4"] = new List<string> { "60 pins", "80 pins", "100 pins", "144 pins", "176 pins" };
            microcontrollerPinPackages["S32K146"] = new List<string> { "64 pins","100 pins", "144 pins" };
            microcontrollerPinPackages["S32K148"] = new List<string> { "100 pins","144 pins", "176 pins" };
           // SelectButton.Enabled = false;

        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMicrocontroller = ComboBoxMicrocontroller.SelectedItem as string;
            if (selectedMicrocontroller != null)
            {
                // Ensure that the dictionary contains an entry for the selected microcontroller
                if (microcontrollerPinPackages.TryGetValue(selectedMicrocontroller, out List<string> pinPackages))
                {
                    // Clear previous items in the ComboBox
                    ComboBoxPinPackage.Items.Clear();
                    // Add pin packages for the selected microcontroller
                    ComboBoxPinPackage.Items.AddRange(pinPackages.ToArray());
                    ComboBoxPinPackage.Enabled = true;
                    SelectButton.Enabled = true;
                        
                 }                 
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
         //  Generate_button.Enabled = false;

        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (ComboBoxMicrocontroller.SelectedIndex != -1 && ComboBoxPinPackage.SelectedIndex != -1)
            {
                //SelectButton.Enabled = true; // Enable the Browse button
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    selectedFileName = openFileDialog.FileName;
                    filePathTextBox.Text = selectedFileName;

                    // Enable the Generate button only if the CSV file is selected
                    if (!string.IsNullOrEmpty(selectedFileName))
                    {
                        Generate_button.Enabled = true;
                    }
                    
                    else
                    {
                        Generate_button.Enabled = false;
                    }
                }

            }
           else  if (ComboBoxMicrocontroller.SelectedIndex != -1 && ComboBoxPinPackage.SelectedIndex != 1)
            {
                MessageBox.Show("Please Select the required Pinpackage." ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (ComboBoxMicrocontroller.SelectedIndex != 1 && ComboBoxPinPackage.SelectedIndex != -1)
            {
                MessageBox.Show(" Please Select the required Microcontroller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           //else if (ComboBoxMicrocontroller.SelectedIndex != 1 && ComboBoxPinPackage.SelectedIndex != 1)
           else
            {
                //SelectButton.Enabled = false; // Disable the Browse button
                //Generate_button.Enabled = false; // Disable the Generate button if selections are not complete
                MessageBox.Show("Please select both Microcontroller and Pin package.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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





        private string generatedCsFilePath;
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

            if (Path.GetExtension(selectedFileName) != ".csv")
            {
                MessageBox.Show("Please select a CSV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if CSV file exists
            if (!File.Exists(selectedFileName))
            {
                MessageBox.Show("Selected CSV file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string[]> csvData = ReadCsvFile(selectedFileName);
            string generatedCsFileName = Path.Combine(Path.GetDirectoryName(selectedFileName), "GeneratedCsvData.cs");
            generatedCsFilePath = generatedCsFileName;

            using (StreamWriter writer = new StreamWriter(generatedCsFileName))
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
          Download_button.Visible = true;
        }


        private List<string[]> ReadCsvFile(string filePath)
        {
            List<string[]> csvData = new List<string[]>();

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("No file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return csvData;
            }

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

        private void Upload_button_Click(object sender, EventArgs e)
        {
            if (ComboBoxMicrocontroller.SelectedIndex != -1 && ComboBoxPinPackage.SelectedIndex != -1 && (!string.IsNullOrEmpty(selectedFileName)))
            {


                MessageBox.Show("File uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("  No File is uploaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Download_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(generatedCsFilePath) && File.Exists(generatedCsFilePath) && Upload_button.Enabled)
            {
                // Offer the file for download
                System.Diagnostics.Process.Start(generatedCsFilePath);
            }
            else
            {
                MessageBox.Show("The generated .cs file is not available for download.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        // private void ShowDownloadedFiles()
        // {
        //    listBoxDownloadedFiles.DataSource = null;
        //     listBoxDownloadedFiles.DataSource = downloadedFiles;
        // }






    }
}
    

