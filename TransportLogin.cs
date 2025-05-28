using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Travel_Ease
{
    public partial class TransportLogin : Form
    {
        public TransportLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = DbConnection.GetConnection();

        private void TransportLogin_Load(object sender, EventArgs e)
        {

        }

        private void usrPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Validate inputs
            // Email: Not empty, valid format
            string email = usrEmail.Text;
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s,;]+@[^@\s,;]+\.[^@\s,;]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password: Not empty
            string password = usrPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database authentication
            try
            {
                con.Open();
                string queryCheck = "SELECT * FROM ServiceProvider " +
                                   "WHERE Email = @email AND Password = @password " +
                                   "AND ProviderType = 3 AND SpStatus = 'Approved'";
                SqlCommand cmd = new SqlCommand(queryCheck, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Navigate to dashboard 
                    // get the ID of the user
                    string query2 = "SELECT ProviderID FROM ServiceProvider WHERE Email = @email AND Password = @password AND ProviderType = 3 AND SpStatus = 'Approved'";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("@email", email);
                    cmd2.Parameters.AddWithValue("@password", password);

                    // Navigate to dashboard 
                    object result = cmd2.ExecuteScalar();
                    if (result != null)
                    {   // pass the login ID aagay to the home/dashboard
                        int providerId = Convert.ToInt32(result);
                        TransportDashboard dashboard = new TransportDashboard(providerId);
                        ///// This is for the Active user report
                        string ActiveUserquery = "Insert into ActiveUsers values (@pID, 'Transport', getDate())";
                        SqlCommand cmd3 = new SqlCommand(ActiveUserquery, con);
                        cmd3.Parameters.AddWithValue("@pID", providerId);
                        cmd3.ExecuteNonQuery();

                        dashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email, password, or account not approved.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usrEmail.Clear();
                    usrPassword.Clear();
                }

                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransportSignup signup = new TransportSignup();
            signup.Show();
            this.Hide();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            HomePage login = new HomePage();
            login.Show();
            this.Hide();
        }
    }
}

