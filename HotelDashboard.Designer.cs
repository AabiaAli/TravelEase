﻿namespace Travel_Ease
{
    partial class HotelDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelDashboard));
            this.Listing = new System.Windows.Forms.TabControl();
            this.Integration = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Button();
            this.roomDesc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServiceListing = new System.Windows.Forms.DataGridView();
            this.Bookings = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelAllocation = new System.Windows.Forms.Button();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.Reports = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.chartPerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbGraphType = new System.Windows.Forms.ComboBox();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Listing.SuspendLayout();
            this.Integration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceListing)).BeginInit();
            this.Bookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Listing
            // 
            this.Listing.Controls.Add(this.Integration);
            this.Listing.Controls.Add(this.tabPage2);
            this.Listing.Controls.Add(this.Bookings);
            this.Listing.Controls.Add(this.Reports);
            this.Listing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Listing.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listing.Location = new System.Drawing.Point(34, 140);
            this.Listing.Name = "Listing";
            this.Listing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Listing.SelectedIndex = 0;
            this.Listing.Size = new System.Drawing.Size(788, 440);
            this.Listing.TabIndex = 0;
            // 
            // Integration
            // 
            this.Integration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(198)))), ((int)(((byte)(192)))));
            this.Integration.Controls.Add(this.label8);
            this.Integration.Controls.Add(this.label2);
            this.Integration.Controls.Add(this.btnReject);
            this.Integration.Controls.Add(this.btnAccept);
            this.Integration.Controls.Add(this.dgvAssignments);
            this.Integration.Location = new System.Drawing.Point(4, 32);
            this.Integration.Name = "Integration";
            this.Integration.Padding = new System.Windows.Forms.Padding(3);
            this.Integration.Size = new System.Drawing.Size(780, 404);
            this.Integration.TabIndex = 0;
            this.Integration.Text = "Accomodation Approvals";
            this.Integration.Click += new System.EventHandler(this.Integration_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(633, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(161, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pending Approvals";
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReject.Location = new System.Drawing.Point(624, 256);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(142, 64);
            this.btnReject.TabIndex = 4;
            this.btnReject.Text = "REJECT";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAccept.Location = new System.Drawing.Point(624, 148);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(142, 64);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "ACCEPT";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Location = new System.Drawing.Point(31, 74);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.RowHeadersWidth = 51;
            this.dgvAssignments.RowTemplate.Height = 24;
            this.dgvAssignments.Size = new System.Drawing.Size(561, 322);
            this.dgvAssignments.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(198)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.price);
            this.tabPage2.Controls.Add(this.roomDesc);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvServiceListing);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service Listing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(622, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "Options";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.ControlLight;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.price.Location = new System.Drawing.Point(612, 243);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(143, 65);
            this.price.TabIndex = 5;
            this.price.Text = "Edit Room Price";
            this.price.UseVisualStyleBackColor = false;
            this.price.Click += new System.EventHandler(this.price_Click);
            // 
            // roomDesc
            // 
            this.roomDesc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roomDesc.Location = new System.Drawing.Point(612, 147);
            this.roomDesc.Name = "roomDesc";
            this.roomDesc.Size = new System.Drawing.Size(143, 67);
            this.roomDesc.TabIndex = 4;
            this.roomDesc.Text = "Edit Room Description";
            this.roomDesc.UseVisualStyleBackColor = false;
            this.roomDesc.Click += new System.EventHandler(this.roomDesc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(146, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listed Accomodations";
            // 
            // dgvServiceListing
            // 
            this.dgvServiceListing.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvServiceListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceListing.Location = new System.Drawing.Point(32, 66);
            this.dgvServiceListing.Name = "dgvServiceListing";
            this.dgvServiceListing.RowHeadersWidth = 51;
            this.dgvServiceListing.RowTemplate.Height = 24;
            this.dgvServiceListing.Size = new System.Drawing.Size(558, 326);
            this.dgvServiceListing.TabIndex = 2;
            // 
            // Bookings
            // 
            this.Bookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(198)))), ((int)(((byte)(192)))));
            this.Bookings.Controls.Add(this.label6);
            this.Bookings.Controls.Add(this.label3);
            this.Bookings.Controls.Add(this.btnCancelAllocation);
            this.Bookings.Controls.Add(this.btnConfirmPayment);
            this.Bookings.Controls.Add(this.dgvBookings);
            this.Bookings.Location = new System.Drawing.Point(4, 32);
            this.Bookings.Name = "Bookings";
            this.Bookings.Padding = new System.Windows.Forms.Padding(3);
            this.Bookings.Size = new System.Drawing.Size(780, 404);
            this.Bookings.TabIndex = 2;
            this.Bookings.Text = "Booking Confirmations";
            this.Bookings.Click += new System.EventHandler(this.Bookings_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(630, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(142, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pending Confirmations";
            // 
            // btnCancelAllocation
            // 
            this.btnCancelAllocation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelAllocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelAllocation.Location = new System.Drawing.Point(621, 248);
            this.btnCancelAllocation.Name = "btnCancelAllocation";
            this.btnCancelAllocation.Size = new System.Drawing.Size(143, 65);
            this.btnCancelAllocation.TabIndex = 2;
            this.btnCancelAllocation.Text = "CANCEL";
            this.btnCancelAllocation.UseVisualStyleBackColor = false;
            this.btnCancelAllocation.Click += new System.EventHandler(this.btnCancelAllocation_Click);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConfirmPayment.Location = new System.Drawing.Point(621, 152);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(143, 67);
            this.btnConfirmPayment.TabIndex = 1;
            this.btnConfirmPayment.Text = "CONFIRM";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // dgvBookings
            // 
            this.dgvBookings.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBookings.Location = new System.Drawing.Point(30, 67);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.Size = new System.Drawing.Size(567, 325);
            this.dgvBookings.TabIndex = 0;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellContentClick);
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(198)))), ((int)(((byte)(192)))));
            this.Reports.Controls.Add(this.label9);
            this.Reports.Controls.Add(this.chartPerformance);
            this.Reports.Controls.Add(this.cmbGraphType);
            this.Reports.Location = new System.Drawing.Point(4, 32);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(780, 404);
            this.Reports.TabIndex = 3;
            this.Reports.Text = "Reports";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.label9.Location = new System.Drawing.Point(34, 26);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(461, 38);
            this.label9.TabIndex = 10;
            this.label9.Text = "Please select the report you want to view : ";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // chartPerformance
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPerformance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPerformance.Legends.Add(legend1);
            this.chartPerformance.Location = new System.Drawing.Point(129, 93);
            this.chartPerformance.Name = "chartPerformance";
            this.chartPerformance.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPerformance.Series.Add(series1);
            this.chartPerformance.Size = new System.Drawing.Size(523, 279);
            this.chartPerformance.TabIndex = 9;
            this.chartPerformance.Text = "chart1";
            // 
            // cmbGraphType
            // 
            this.cmbGraphType.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.cmbGraphType.FormattingEnabled = true;
            this.cmbGraphType.Items.AddRange(new object[] {
            "Occupancy",
            "Ratings",
            "Revenue"});
            this.cmbGraphType.Location = new System.Drawing.Point(530, 26);
            this.cmbGraphType.Name = "cmbGraphType";
            this.cmbGraphType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbGraphType.Size = new System.Drawing.Size(196, 35);
            this.cmbGraphType.TabIndex = 8;
            this.cmbGraphType.SelectedIndexChanged += new System.EventHandler(this.cmbGraphType_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(198)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(847, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 378);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logoutButton.Location = new System.Drawing.Point(857, 394);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(143, 67);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "LOG OUT";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exitButton.Location = new System.Drawing.Point(857, 478);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 67);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 26F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(351, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "MY WORKSPACE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(881, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(896, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "MENU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button1.Location = new System.Drawing.Point(857, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 67);
            this.button1.TabIndex = 18;
            this.button1.Text = "VIEW POPULAR DESTINATIONS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HotelDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1042, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Listing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotelDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelDashboard";
            this.Load += new System.EventHandler(this.HotelDashboard_Load);
            this.Listing.ResumeLayout(false);
            this.Integration.ResumeLayout(false);
            this.Integration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceListing)).EndInit();
            this.Bookings.ResumeLayout(false);
            this.Bookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.Reports.ResumeLayout(false);
            this.Reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Listing;
        private System.Windows.Forms.TabPage Integration;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Bookings;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dgvServiceListing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelAllocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button price;
        private System.Windows.Forms.Button roomDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPerformance;
        private System.Windows.Forms.ComboBox cmbGraphType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}