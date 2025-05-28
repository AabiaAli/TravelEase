using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Travel_Ease.HotelSignup;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Travel_Ease
{
    public partial class TransportSignup : Form
    {
        public TransportSignup()
        {
            InitializeComponent();
            this.Load += new EventHandler(TransportSignup_Load); // Ensure Load event is subscribed

        }
        SqlConnection con = DbConnection.GetConnection();

        private void TransportSignup_Load(object sender, EventArgs e)
        {

            // Populate Destination ComboBox
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT d.DestinationID, ISNULL(d.Name, '') + ', ' + l.CityName AS DisplayName " +
                    "FROM Destination d " +
                    "JOIN Location l ON d.LocationID = l.LocationID " +
                    "ORDER BY l.CityName, d.Name", con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<DestinationItem> destinations = new List<DestinationItem>();
                while (reader.Read())
                {
                    destinations.Add(new DestinationItem
                    {
                        DisplayName = reader["DisplayName"].ToString(),
                        DestinationID = (int)reader["DestinationID"]
                    });
                }
                reader.Close();
                usrDestination.DataSource = destinations;
                usrDestination.DisplayMember = "DisplayName";
                usrDestination.ValueMember = "DestinationID";
                usrDestination.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading destinations: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            // Validate inputs
            // Transport Name: Not empty, ≤ 100 characters
            if (string.IsNullOrEmpty(usrName.Text) || usrName.Text.Length > 100)
            {
                MessageBox.Show("Transport Name is required and must be ≤ 100 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email: Valid format and unique
            string email = usrEmail.Text;
            if (!Regex.IsMatch(email, @"^[^@\s,;]+@[^@\s,;]+\.[^@\s,;]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (email.Length > 100)
            {
                MessageBox.Show("Email must be ≤ 100 characters.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                con.Open();
                SqlCommand emailCheck = new SqlCommand("SELECT COUNT(*) FROM ServiceProvider WHERE Email = @email", con);
                emailCheck.Parameters.AddWithValue("@email", email);
                int emailExists = (int)emailCheck.ExecuteScalar();
                if (emailExists > 0)
                {
                    MessageBox.Show("Email is already registered. Please use another.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error checking email: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            // Password: 8–15 characters
            string password = usrPassword.Text;
            if (password.Length < 8 || password.Length > 15)
            {
                MessageBox.Show("Password must be 8–15 characters.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Destination: Must be selected
            if (usrDestination.SelectedIndex == -1)
            {
                MessageBox.Show("Select a destination.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Transport Type: Must be selected
            if (usrTransportType.SelectedIndex == -1)
            {
                MessageBox.Show("Select a transport type.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Total Seats: ≥ 0 (ensured by NumericUpDown)
            if (usrTotalSeats.Value < 0)
            {
                MessageBox.Show("Total Seats must be ≥ 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database insertion
            try
            {
                con.Open();

                // Insert into ServiceProvider
                string queryProvider = @"
                    INSERT INTO ServiceProvider (ProviderName, Email, Password, RegistrationDate, SpStatus, DestinationID, ProviderType)
                    VALUES (@name, @email, @pwd, @regdate, @status, @destid, @type)";
                   // SELECT SCOPE_IDENTITY();"; // Add SELECT to return the new ProviderID
                SqlCommand cmdProvider = new SqlCommand(queryProvider, con);
                cmdProvider.Parameters.AddWithValue("@name", usrName.Text.Trim());
                cmdProvider.Parameters.AddWithValue("@email", email.Trim());
                cmdProvider.Parameters.AddWithValue("@pwd", password.Trim());
                cmdProvider.Parameters.AddWithValue("@regdate", DateTime.Today);
                cmdProvider.Parameters.AddWithValue("@status", "Pending");
                cmdProvider.Parameters.AddWithValue("@type", 3); // 3 = Transport


                // Validate and add DestinationID
                if (usrDestination.SelectedValue != null && int.TryParse(usrDestination.SelectedValue.ToString(), out int destId))
                {
                    cmdProvider.Parameters.AddWithValue("@destid", destId);
                }
                else
                {
                    MessageBox.Show("Please select a valid destination.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Execute and get the new ProviderID
                cmdProvider.ExecuteNonQuery();

                string getProviderID = "SELECT TOP 1 ProviderID FROM ServiceProvider ORDER BY ProviderID DESC";
                SqlCommand getIdCmd = new SqlCommand(getProviderID, con);
                int providerId = (int)getIdCmd.ExecuteScalar(); //get the last inserted ProviderID

                // Insert into TransportService
                string queryTransport = "INSERT INTO TransportService (ProviderID, Type, TotalSeats, OccupiedSeats) " +
                                       "VALUES (@providerid, @type, @totalseats, @occupiedseats)";
                SqlCommand cmdTransport = new SqlCommand(queryTransport, con);
                cmdTransport.Parameters.AddWithValue("@providerid", providerId);
                cmdTransport.Parameters.AddWithValue("@type", usrTransportType.SelectedItem?.ToString() ?? "");
                cmdTransport.Parameters.AddWithValue("@totalseats", (int)usrTotalSeats.Value);
                cmdTransport.Parameters.AddWithValue("@occupiedseats", 0);

                cmdTransport.ExecuteNonQuery();

                MessageBox.Show("Transport provider registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear form
                usrName.Clear();
                usrEmail.Clear();
                usrPassword.Clear();
                usrDestination.SelectedIndex = -1;
                usrTransportType.SelectedIndex = -1;
                usrTotalSeats.Value = 0;
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

        private void goBack_Click(object sender, EventArgs e)
        {
            HomePage login = new HomePage();
            login.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransportLogin form = new TransportLogin();
            form.Show();
            this.Hide();
        }

        private void usrDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
