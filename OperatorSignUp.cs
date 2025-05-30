﻿using Travel_Ease;
using System;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Travel_Ease
{
    public partial class OperatorSignUp : Form
    {
        public OperatorSignUp()
        {
            InitializeComponent();
        }

        private readonly string connectionString = "Data Source=AABIA\\SQLEXPRESS;Initial Catalog = TravelEase; Integrated Security = True; Encrypt=False";

        private void signupButton_Click(object sender, EventArgs e)
        {
            string companyName = CompanyName.Text.Trim();
            string email = this.email.Text.Trim();
            string contactNo = ContactNo.Text.Trim();
            string password = this.password.Text.Trim();

            if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(contactNo) || string.IsNullOrEmpty(password))
            {
                CustomMessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    // Optional: check for duplicates (e.g., company name or email)
                    string checkQuery = "SELECT COUNT(*) FROM Operator WHERE Email = @Email OR CompanyName = @CompanyName";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        checkCmd.Parameters.AddWithValue("@CompanyName", companyName);

                        int existing = (int)checkCmd.ExecuteScalar();
                        if (existing > 0)
                        {
                            CustomMessageBox.Show("Operator with this email or company name already exists.");
                            return;
                        }
                    }

                    // Insert operator with current date and OpStatus = false
                    string insertQuery = @"INSERT INTO Operator 
                        (CompanyName, Email, ContactNo, Password, RegistrationDate, OpStatus) 
                        VALUES (@CompanyName, @Email, @ContactNo, @Password, @RegistrationDate, 'Pending')";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        string defaultstatus = "Pending";

                        cmd.Parameters.AddWithValue("@CompanyName", companyName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@ContactNo", contactNo);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);
                      //  cmd.Parameters.AddWithValue("@OpStatus", "P); 

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            CustomMessageBox.Show("Operator signed up successfully!");
                        }
                        else
                        {
                            CustomMessageBox.Show("Error during sign up.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error signing up.\n" + ex.Message);
            }
        }

        // Optional handlers for future validations
        private void OperatorSignUpcs_Load(object sender, EventArgs e) { }

        private void CompanyName_TextChanged(object sender, EventArgs e) { }

        private void email_TextChanged(object sender, EventArgs e) { }

        private void password_TextChanged(object sender, EventArgs e) { }

        private void ContactNo_TextChanged(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OperatorSignIn form = new OperatorSignIn();
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
