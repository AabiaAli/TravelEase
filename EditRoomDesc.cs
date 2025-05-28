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
    public partial class EditRoomDesc : Form
    {
        private int _accomodationId;
        public EditRoomDesc(int accomodationId, string roomDesc)
        {
            InitializeComponent();
            _accomodationId = accomodationId;
            txtDescription.Text = roomDesc;
        }
        SqlConnection conn = DbConnection.GetConnection();
        private void EditRoomDesc_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Room description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update Accommodation table
               // using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        UPDATE Accommodation
                        SET RoomDesc = @RoomDesc
                        WHERE AccomodationID = @AccomodationID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RoomDesc", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@AccomodationID", _accomodationId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Failed to update room description. Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Room description updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room description: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
    
}
