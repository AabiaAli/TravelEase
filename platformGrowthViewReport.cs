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
using Microsoft.Reporting.WinForms;

namespace Travel_Ease
{
    public partial class platformGrowthViewReport : Form
    {
        public int AdminID { get; set; } //so that traveler is retained when returning home, can be changed to whoever's id's interface this report is in and you can set it using the object created
        /*for example:
         * destinationPopularity dest = new destinationPopulatiry();
         * dest.TravelerID = this.TravelerID; //assuming we r in traveler
         * dest.Show(); //will load for that traveler
         */
        const string reportPath = "Hotel_and_Transport.PlatformGrowthReport.rdlc";
        public platformGrowthViewReport()
        {
            InitializeComponent();
        }

        SqlConnection con = DbConnection.GetConnection();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void LoadReportData()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                // 1. New User Registrations: past year
                string queryNewUsers = @"
             SELECT 
                 FORMAT(sp.RegistrationDate, 'yyyy-MM') AS RegistrationMonth,
                 'ServiceProvider' AS UserType,
                 COUNT(*) AS RegistrationCount
             FROM ServiceProvider sp
             WHERE sp.RegistrationDate >= DATEADD(MONTH, -12, GETDATE())
             GROUP BY FORMAT(sp.RegistrationDate, 'yyyy-MM')
             UNION ALL
             SELECT 
                 FORMAT(o.RegistrationDate, 'yyyy-MM') AS RegistrationMonth,
                 'Operator' AS UserType,
                 COUNT(*) AS RegistrationCount
             FROM Operator o
             WHERE o.RegistrationDate >= DATEADD(MONTH, -12, GETDATE())
             GROUP BY FORMAT(o.RegistrationDate, 'yyyy-MM')
             UNION ALL
             SELECT 
                 FORMAT(t.RegistrationDate, 'yyyy-MM') AS RegistrationMonth,
                 'Traveler' AS UserType,
                 COUNT(*) AS RegistrationCount
             FROM Traveler t
             WHERE t.RegistrationDate >= DATEADD(MONTH, -12, GETDATE())
             GROUP BY FORMAT(t.RegistrationDate, 'yyyy-MM')
             ORDER BY RegistrationMonth, UserType;";
                SqlDataAdapter daNewUsers = new SqlDataAdapter(queryNewUsers, con);
                DataTable dtNewUsers = new DataTable();
                daNewUsers.Fill(dtNewUsers);
                if (dtNewUsers.Rows.Count == 0) dtNewUsers.Rows.Add("2024-11", "Traveler", 0);
                ReportDataSource rdsNewUsers = new ReportDataSource("NewUsersDataSet", dtNewUsers);

                // 2. Active Users: logged in recently
                string queryActiveUsers = @"        
             WITH MonthRange AS (
                 SELECT FORMAT(DATEADD(MONTH, -n.number, CAST(GETDATE() AS DATE)), 'yyyy-MM') AS Month
                 FROM master.dbo.spt_values n
                 WHERE n.type = 'P' AND n.number BETWEEN 0 AND 11
             ),
             UserTypes AS (
                 SELECT 'Traveler' AS UserType
                 UNION ALL
                 SELECT 'Operator'
                 UNION ALL
                 SELECT 'ServiceProvider'
             ),
             MonthUserCombinations AS (
                 SELECT m.Month, u.UserType
                 FROM MonthRange m
                 CROSS JOIN UserTypes u
             ),
             ActiveUserCounts AS (
                 SELECT 
                     FORMAT(acessDate, 'yyyy-MM') AS Month,
                     UserType,
                     COUNT(DISTINCT UserID) AS ActiveUserCount
                 FROM ActiveUsers
                 WHERE acessDate >= DATEADD(MONTH, -12, GETDATE())
                 GROUP BY FORMAT(acessDate, 'yyyy-MM'), UserType
             )
             SELECT 
                 muc.Month,
                 muc.UserType,
                 ISNULL(auc.ActiveUserCount, 0) AS ActiveUserCount
             FROM MonthUserCombinations muc
             LEFT JOIN ActiveUserCounts auc
                 ON muc.Month = auc.Month AND muc.UserType = auc.UserType
             ORDER BY muc.Month, muc.UserType;
             ";
                SqlDataAdapter daActiveUsers = new SqlDataAdapter(queryActiveUsers, con);
                DataTable dtActiveUsers = new DataTable();
                daActiveUsers.Fill(dtActiveUsers);
                if (dtActiveUsers.Rows.Count == 0) dtActiveUsers.Rows.Add("2024-05", "Traveler", 0);
                ReportDataSource rdsActiveUsers = new ReportDataSource("ActiveUsersDataSet", dtActiveUsers);

                // 3. Partnership Growth
                string queryPartnershipGrowth = @"
             SELECT 
                 FORMAT(RegistrationDate, 'yyyy-MM') AS Month,
                 'Operator' AS UserType,
                 COUNT(*) AS NewRegistrations
             FROM Operator
             WHERE RegistrationDate >= DATEADD(MONTH, -12, GETDATE())
             GROUP BY FORMAT(RegistrationDate, 'yyyy-MM')
             UNION ALL
             SELECT 
                 FORMAT(RegistrationDate, 'yyyy-MM') AS Month,
                 'ServiceProvider' AS UserType,
                 COUNT(*) AS NewRegistrations
             FROM ServiceProvider
             WHERE RegistrationDate >= DATEADD(MONTH, -12, GETDATE())
             GROUP BY FORMAT(RegistrationDate, 'yyyy-MM')
             ORDER BY Month, UserType;";
                SqlDataAdapter daPartnershipGrowth = new SqlDataAdapter(queryPartnershipGrowth, con);
                DataTable dtPartnershipGrowth = new DataTable();
                daPartnershipGrowth.Fill(dtPartnershipGrowth);
                if (dtPartnershipGrowth.Rows.Count == 0) dtPartnershipGrowth.Rows.Add("2024-05", "Operator", 0);
                ReportDataSource rdsPartnershipGrowth = new ReportDataSource("PartnershipGrowthDataSet", dtPartnershipGrowth);

                // 4. Regional Expansion
                string queryRegionalExpansion = @"
             SELECT 
                 FORMAT(DateAdded, 'yyyy-MM') AS Month,
                 COUNT(*) AS NewDestinations
             FROM Destination
             GROUP BY FORMAT(DateAdded, 'yyyy-MM')
             ORDER BY Month;";
                SqlDataAdapter daRegionalExpansion = new SqlDataAdapter(queryRegionalExpansion, con);
                DataTable dtRegionalExpansion = new DataTable();
                daRegionalExpansion.Fill(dtRegionalExpansion);
                if (dtRegionalExpansion.Rows.Count == 0) dtRegionalExpansion.Rows.Add("2024-05", 0);
                ReportDataSource rdsRegionalExpansion = new ReportDataSource("RegionalExpansionDataSet", dtRegionalExpansion);

                // Bind to ReportViewer
                try
                {
                    reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rdsNewUsers);
                    reportViewer1.LocalReport.DataSources.Add(rdsActiveUsers);
                    reportViewer1.LocalReport.DataSources.Add(rdsPartnershipGrowth);
                    reportViewer1.LocalReport.DataSources.Add(rdsRegionalExpansion);
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message + "\nInner Exception: " + (ex.InnerException?.Message ?? "None"));
                }
            }
        }



        private void platformGrowthViewReport_Load(object sender, EventArgs e)
        {

        }

        private void platformGrowthViewReport_Load_1(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin(this.AdminID);
            adm.Show();
            this.Hide();
        }
    }
}
