
using Travel_Ease;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Travel_Ease
{
    public partial class AdminSignIn : Form
    {
        public AdminSignIn()
        {
            InitializeComponent();
        }

        private void AdminSignIn_Load(object sender, EventArgs e) { }

        private void Username_TextChanged(object sender, EventArgs e) { }

        private void Pass_TextChanged(object sender, EventArgs e) { }




   

        private void signupButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string password = Pass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int result = (int)cmd.ExecuteScalar();

                    if (result == 1)
                    {
                        MessageBox.Show("Login successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Navigate to dashboard 
                        // get the ID of the user
                        string query2 = "SELECT AdminID FROM Admin WHERE Username = @username AND Password = @password ";
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        cmd2.Parameters.AddWithValue("@username", username);
                        cmd2.Parameters.AddWithValue("@password", password);

                        // Navigate to dashboard 
                        object result2 = cmd2.ExecuteScalar();
                        if (result2 != null)
                        {

                            // pass the login ID aagay to the home/dashboard
                            int Admin_Id = Convert.ToInt32(result2);
                            Admin dashboard = new Admin(Admin_Id);

                            ///// This is for the Active user report
                            string ActiveUserquery = "Insert into ActiveUsers values (@pID, 'Admin', getDate())";
                            SqlCommand cmd3 = new SqlCommand(ActiveUserquery, conn);
                            cmd3.Parameters.AddWithValue("@pID", Admin_Id);
                            cmd3.ExecuteNonQuery();

                            dashboard.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Username.Clear();
                        Pass.Clear();
                    }

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminSigningUp form = new AdminSigningUp();
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

