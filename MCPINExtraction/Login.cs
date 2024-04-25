using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCPINExtraction
{
    public partial class Login : Form
    {
      
        SqlConnection cn;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\INTERNUSER03\source\repos\MCPINExtraction\MCPINExtraction\Databasedetails.mdf;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM LoginTable WHERE username = @username COLLATE Latin1_General_CS_AS AND password = @password COLLATE Latin1_General_CS_AS";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", txtusername.Text);
                        command.Parameters.AddWithValue("@password", txtpassword.Text);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                // Authentication successful
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reader.Close();
                                UserLogName.Username = txtusername.Text;
                                this.Hide();
                                Home home = new Home();
                                home.ShowDialog();
                            }
                            else
                            {
                                // Authentication failed
                                MessageBox.Show("Authentication failed. Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                reader.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\INTERNUSER03\source\repos\MCPINExtraction\MCPINExtraction\Databasedetails.mdf;Integrated Security=True");

            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    


    }
}

