using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Claims;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using Travel_Ease;

namespace Travel_Ease
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // Check which radio button is selected and open the corresponding signup form
            if (travellerradioButton.Checked)
            {
                travelerSignUp signupForm = new travelerSignUp();
                signupForm.Show();
                this.Hide(); // Optionally hide the homepage
            }
            else if (operatorradioButton.Checked)
            {
                OperatorSignUp signupForm = new OperatorSignUp();
                signupForm.Show();
                this.Hide();
            }
            else if (guideradioButton.Checked)
            {
                GuideSignup signupForm = new GuideSignup();
                signupForm.Show();
                this.Hide();
            }
            else if (transportserviceradioButton.Checked)
            {
                TransportSignup signupForm = new TransportSignup();
                signupForm.Show();
                this.Hide();
            }
            else if (hotelierradioButton.Checked)
            {
                HotelSignup signupForm = new HotelSignup();
                signupForm.Show();
                this.Hide();
            }
            else if (adminRadiobutton.Checked)
            {
                AdminSigningUp signupForm = new AdminSigningUp();
                signupForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select an interface to sign up for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
