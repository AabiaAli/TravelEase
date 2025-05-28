using System.Windows.Forms;

namespace Travel_Ease
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ApproveStatus = new System.Windows.Forms.Button();
            this.PendingUsers = new System.Windows.Forms.DataGridView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTripCategory = new System.Windows.Forms.Button();
            this.TripCategoriesGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AdminReports = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ReportComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RejectButton = new System.Windows.Forms.Button();
            this.approveReview = new System.Windows.Forms.Button();
            this.inappropriateReviewDataGrid = new System.Windows.Forms.DataGridView();
            this.pendingReviewDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PendingUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TripCategoriesGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inappropriateReviewDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingReviewDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 128);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.ApproveStatus);
            this.tabPage1.Controls.Add(this.PendingUsers);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(837, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(185)))));
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button1.Location = new System.Drawing.Point(567, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 57);
            this.button1.TabIndex = 23;
            this.button1.Text = "Reject";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label11.Location = new System.Drawing.Point(30, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(532, 43);
            this.label11.TabIndex = 22;
            this.label11.Text = "Users With Pending Status";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ApproveStatus
            // 
            this.ApproveStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(185)))));
            this.ApproveStatus.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.ApproveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ApproveStatus.Location = new System.Drawing.Point(567, 257);
            this.ApproveStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ApproveStatus.Name = "ApproveStatus";
            this.ApproveStatus.Size = new System.Drawing.Size(195, 57);
            this.ApproveStatus.TabIndex = 21;
            this.ApproveStatus.Text = "Approve";
            this.ApproveStatus.UseVisualStyleBackColor = false;
            this.ApproveStatus.Click += new System.EventHandler(this.ApproveStatus_Click);
            // 
            // PendingUsers
            // 
            this.PendingUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingUsers.Location = new System.Drawing.Point(37, 87);
            this.PendingUsers.Margin = new System.Windows.Forms.Padding(4);
            this.PendingUsers.Name = "PendingUsers";
            this.PendingUsers.RowHeadersWidth = 51;
            this.PendingUsers.Size = new System.Drawing.Size(476, 252);
            this.PendingUsers.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(-439, -65);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1745, 796);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.AddTripCategory);
            this.tabPage2.Controls.Add(this.TripCategoriesGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(837, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tour Categories Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(199, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 51);
            this.label1.TabIndex = 23;
            this.label1.Text = "Trip Categories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddTripCategory
            // 
            this.AddTripCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(185)))));
            this.AddTripCategory.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.AddTripCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.AddTripCategory.Location = new System.Drawing.Point(315, 292);
            this.AddTripCategory.Margin = new System.Windows.Forms.Padding(4);
            this.AddTripCategory.Name = "AddTripCategory";
            this.AddTripCategory.Size = new System.Drawing.Size(169, 46);
            this.AddTripCategory.TabIndex = 22;
            this.AddTripCategory.Text = "Add Category";
            this.AddTripCategory.UseVisualStyleBackColor = false;
            this.AddTripCategory.Click += new System.EventHandler(this.AddTripCategory_Click);
            // 
            // TripCategoriesGridView
            // 
            this.TripCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TripCategoriesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.TripCategoriesGridView.Location = new System.Drawing.Point(297, 105);
            this.TripCategoriesGridView.Margin = new System.Windows.Forms.Padding(4);
            this.TripCategoriesGridView.Name = "TripCategoriesGridView";
            this.TripCategoriesGridView.RowHeadersWidth = 51;
            this.TripCategoriesGridView.Size = new System.Drawing.Size(203, 162);
            this.TripCategoriesGridView.TabIndex = 3;
            this.TripCategoriesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TripCategoriesGridView_CellContentClick_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AdminReports);
            this.tabPage3.Controls.Add(this.ReportComboBox);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(837, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Platform Analytics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AdminReports
            // 
            chartArea4.Name = "ChartArea1";
            this.AdminReports.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.AdminReports.Legends.Add(legend4);
            this.AdminReports.Location = new System.Drawing.Point(108, 58);
            this.AdminReports.Margin = new System.Windows.Forms.Padding(4);
            this.AdminReports.Name = "AdminReports";
            this.AdminReports.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.AdminReports.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(53))))),
        System.Drawing.Color.Teal,
        System.Drawing.Color.CadetBlue};
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.AdminReports.Series.Add(series4);
            this.AdminReports.Size = new System.Drawing.Size(596, 286);
            this.AdminReports.TabIndex = 3;
            this.AdminReports.Text = "chart1";
            this.AdminReports.Click += new System.EventHandler(this.AdminReports_Click_2);
            // 
            // ReportComboBox
            // 
            this.ReportComboBox.FormattingEnabled = true;
            this.ReportComboBox.Location = new System.Drawing.Point(593, 26);
            this.ReportComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReportComboBox.Name = "ReportComboBox";
            this.ReportComboBox.Size = new System.Drawing.Size(160, 24);
            this.ReportComboBox.TabIndex = 2;
            this.ReportComboBox.SelectedIndexChanged += new System.EventHandler(this.reportComboBox_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(-462, -65);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1745, 796);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RejectButton);
            this.tabPage4.Controls.Add(this.approveReview);
            this.tabPage4.Controls.Add(this.inappropriateReviewDataGrid);
            this.tabPage4.Controls.Add(this.pendingReviewDataGrid);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(837, 367);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Review Moderation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RejectButton
            // 
            this.RejectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(185)))));
            this.RejectButton.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold);
            this.RejectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.RejectButton.Location = new System.Drawing.Point(223, 295);
            this.RejectButton.Margin = new System.Windows.Forms.Padding(4);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(147, 39);
            this.RejectButton.TabIndex = 29;
            this.RejectButton.Text = "Reject";
            this.RejectButton.UseVisualStyleBackColor = false;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // approveReview
            // 
            this.approveReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(185)))));
            this.approveReview.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold);
            this.approveReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.approveReview.Location = new System.Drawing.Point(38, 295);
            this.approveReview.Margin = new System.Windows.Forms.Padding(4);
            this.approveReview.Name = "approveReview";
            this.approveReview.Size = new System.Drawing.Size(162, 39);
            this.approveReview.TabIndex = 28;
            this.approveReview.Text = "Approve ";
            this.approveReview.UseVisualStyleBackColor = false;
            this.approveReview.Click += new System.EventHandler(this.approveReview_Click);
            // 
            // inappropriateReviewDataGrid
            // 
            this.inappropriateReviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inappropriateReviewDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.inappropriateReviewDataGrid.Location = new System.Drawing.Point(433, 87);
            this.inappropriateReviewDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.inappropriateReviewDataGrid.Name = "inappropriateReviewDataGrid";
            this.inappropriateReviewDataGrid.RowHeadersWidth = 51;
            this.inappropriateReviewDataGrid.Size = new System.Drawing.Size(331, 167);
            this.inappropriateReviewDataGrid.TabIndex = 27;
            // 
            // pendingReviewDataGrid
            // 
            this.pendingReviewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pendingReviewDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.pendingReviewDataGrid.Location = new System.Drawing.Point(45, 87);
            this.pendingReviewDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pendingReviewDataGrid.Name = "pendingReviewDataGrid";
            this.pendingReviewDataGrid.RowHeadersWidth = 51;
            this.pendingReviewDataGrid.Size = new System.Drawing.Size(313, 167);
            this.pendingReviewDataGrid.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(459, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 36);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rejected Reviews";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(66, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pending Reviews";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-520, -46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1745, 796);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(206)))));
            this.label10.Location = new System.Drawing.Point(309, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(334, 43);
            this.label10.TabIndex = 2;
            this.label10.Text = "MY WORKSPACE";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(185)))));
            this.logout.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.logout.Location = new System.Drawing.Point(869, 161);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(181, 68);
            this.logout.TabIndex = 19;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(185)))));
            this.exit.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.exit.Location = new System.Drawing.Point(869, 442);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(181, 68);
            this.exit.TabIndex = 20;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(185)))));
            this.button2.Font = new System.Drawing.Font("Stencil", 12.75F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button2.Location = new System.Drawing.Point(869, 352);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 68);
            this.button2.TabIndex = 21;
            this.button2.Text = "PLATFORM GROWTH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(192)))), ((int)(((byte)(185)))));
            this.button3.Font = new System.Drawing.Font("Stencil", 12.75F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button3.Location = new System.Drawing.Point(869, 256);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 68);
            this.button3.TabIndex = 22;
            this.button3.Text = "Abandoned Bookings";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PendingUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TripCategoriesGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inappropriateReviewDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingReviewDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView PendingUsers;
        private System.Windows.Forms.Button ApproveStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddTripCategory;
        private System.Windows.Forms.DataGridView TripCategoriesGridView;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private DataGridView inappropriateReviewDataGrid;
        private DataGridView pendingReviewDataGrid;
        private Label label3;
        private Button approveReview;
        private Button RejectButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart AdminReports;
        private ComboBox ReportComboBox;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
