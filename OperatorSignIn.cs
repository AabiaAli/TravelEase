using Travel_Ease;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Travel_Ease
{
    public partial class OperatorSignIn : Form
    {
        public OperatorSignIn()
        {
            InitializeComponent();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            // Optional: you can add live validation here
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            // Optional
        }

        private void Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformLogin();
                e.Handled = true;
                e.SuppressKeyPress = true; // prevents the ding sound
            }
        }

        private void PerformLogin()
        {
            string email = Email.Text.Trim();
            string password = Pass.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            using (SqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    // First query to check login credentials and status
                    string query = "SELECT OpStatus FROM Operator WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        CustomMessageBox.Show("Invalid email or password.");
                    }
                    else
                    {
                        string status = result.ToString();
                        if (status == "Approved")
                        {
                            CustomMessageBox.Show("Operator signed in successfully!");
                            // Second query to get OperatorID
                            string IDquery = "SELECT OperatorID FROM Operator WHERE Email = @Email AND Password = @Password";
                            SqlCommand cmd2 = new SqlCommand(IDquery, conn);
                            cmd2.Parameters.AddWithValue("@Email", email); // Use new parameters for cmd2
                            cmd2.Parameters.AddWithValue("@Password", password);

                            object result2 = cmd2.ExecuteScalar(); // Execute the second command

                            if (result2 != null)
                            {
                                int operatorId = Convert.ToInt32(result2);
                                Operator op = new Operator(operatorId); // Pass the ID to the Operator form
                                                                        ///// This is for the Active user report
                                string ActiveUserquery = "Insert into ActiveUsers values (@pID, 'Operator', getDate())";
                                SqlCommand cmd3 = new SqlCommand(ActiveUserquery, conn);
                                cmd3.Parameters.AddWithValue("@pID", operatorId);
                                cmd3.ExecuteNonQuery();

                                op.Show();
                                this.Close(); // Close the login form instead of hiding
                            }
                            else
                            {
                                CustomMessageBox.Show("Error retrieving Operator ID.");
                            }
                        }
                        else
                        {
                            CustomMessageBox.Show("Please ask admin to approve your status.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Pass_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                // MessageBox.Show("Enter key pressed"); // TEST
                PerformLogin();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void OperatorSignIn_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OperatorSignUp form = new OperatorSignUp();
            form.Show();
            this.Hide();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }
    }
}
