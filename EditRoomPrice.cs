using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Travel_Ease
{
    public partial class EditRoomPrice : Form
    {
        private int _accomodationId;
        public EditRoomPrice(int accomodationId, decimal pricePerNight)
        {
            InitializeComponent();
            _accomodationId = accomodationId;
            RoomPrice.Text = pricePerNight.ToString("F2");
        }
        SqlConnection conn = DbConnection.GetConnection();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (!decimal.TryParse(RoomPrice.Text, out decimal pricePerNight) || pricePerNight <= 0)
                {
                    MessageBox.Show("Price per night must be a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update Accommodation table
                {
                    conn.Open();
                    string query = @"
                        UPDATE Accommodation
                        SET PricePerNight = @PricePerNight
                        WHERE AccomodationID = @AccomodationID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PricePerNight", pricePerNight);
                    cmd.Parameters.AddWithValue("@AccomodationID", _accomodationId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Failed to update price per night. Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Price per night updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating price per night: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditRoomPrice_Load(object sender, EventArgs e)
        {

        }
    }
}
