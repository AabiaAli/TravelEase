using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Add this for SQL Server connection
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Travel_Ease
{
    public partial class AdminSigningUp : Form
    {
        public AdminSigningUp()
        {
            InitializeComponent();
        }

        // Connection string for your database
        SqlConnection conn = DbConnection.GetConnection();


        private void Username_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string password = Pass.Text.Trim();
            string email = Email.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                CustomMessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                {
                    conn.Open();

                    // Check if user with same username or email exists
                    string checkQuery = "SELECT Password FROM ADMIN WHERE Username = @Username OR Email = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        checkCmd.Parameters.AddWithValue("@Email", email);

                        object result = checkCmd.ExecuteScalar();

                        if (result != null) // User exists
                        {
                            string existingPassword = result.ToString();
                            if (existingPassword == password)
                            {
                                CustomMessageBox.Show("Admin already exists. Please sign in.");
                            }
                            else
                            {
                                CustomMessageBox.Show("Incorrect username or password.");
                            }
                            return;
                        }
                    }

                    // If not exists, insert new admin
                    string insertQuery = "INSERT INTO ADMIN (Username, Password, Email) VALUES (@Username, @Password, @Email)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Username", username);
                        insertCmd.Parameters.AddWithValue("@Password", password);
                        insertCmd.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            CustomMessageBox.Show("Admin signed up successfully!");
                        }
                        else
                        {
                            CustomMessageBox.Show("Error signing up.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error signing up.\n" + ex.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void AdminSigningUp_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminSignIn form = new AdminSignIn();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }
    }
}
