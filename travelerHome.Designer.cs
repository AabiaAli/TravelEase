﻿namespace Travel_Ease
{
    partial class travelerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(travelerHome));
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGroupSize = new System.Windows.Forms.ComboBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.cmbTripType = new System.Windows.Forms.ComboBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnViewWishlist = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPackages = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cmbSusScore = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clbAccessibility = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCustomTrip = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnTravelHistory = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.btnReviews = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.clbActivities = new System.Windows.Forms.CheckedListBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(574, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Duration (Days)";
            // 
            // btnPrev
            // 
            this.btnPrev.AllowDrop = true;
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrev.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnPrev.Location = new System.Drawing.Point(774, 570);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(120, 46);
            this.btnPrev.TabIndex = 11;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(600, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trip Type";
            // 
            // btnNext
            // 
            this.btnNext.AllowDrop = true;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnNext.Location = new System.Drawing.Point(949, 570);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 46);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(715, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Group Size (Number of People)";
            // 
            // btnFilter
            // 
            this.btnFilter.AllowDrop = true;
            this.btnFilter.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnFilter.Location = new System.Drawing.Point(867, 513);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 33);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Apply Filters";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label4.Location = new System.Drawing.Point(572, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "Search with a keyword (city, title e.g. \"Paris\")\r\n\r\n";
            // 
            // cmbGroupSize
            // 
            this.cmbGroupSize.BackColor = System.Drawing.Color.MintCream;
            this.cmbGroupSize.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cmbGroupSize.FormattingEnabled = true;
            this.cmbGroupSize.Items.AddRange(new object[] {
            "Any",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbGroupSize.Location = new System.Drawing.Point(747, 458);
            this.cmbGroupSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGroupSize.Name = "cmbGroupSize";
            this.cmbGroupSize.Size = new System.Drawing.Size(108, 25);
            this.cmbGroupSize.TabIndex = 8;
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.BackColor = System.Drawing.Color.MintCream;
            this.txtMinPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtMinPrice.Location = new System.Drawing.Point(578, 390);
            this.txtMinPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(104, 25);
            this.txtMinPrice.TabIndex = 16;
            // 
            // cmbTripType
            // 
            this.cmbTripType.BackColor = System.Drawing.Color.MintCream;
            this.cmbTripType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTripType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cmbTripType.FormattingEnabled = true;
            this.cmbTripType.Location = new System.Drawing.Point(578, 458);
            this.cmbTripType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTripType.Name = "cmbTripType";
            this.cmbTripType.Size = new System.Drawing.Size(108, 25);
            this.cmbTripType.TabIndex = 7;
            this.cmbTripType.SelectedIndexChanged += new System.EventHandler(this.cmbTripType_SelectedIndexChanged);
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.BackColor = System.Drawing.Color.MintCream;
            this.txtMaxPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtMaxPrice.Location = new System.Drawing.Point(736, 390);
            this.txtMaxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(104, 25);
            this.txtMaxPrice.TabIndex = 17;
            // 
            // cmbDuration
            // 
            this.cmbDuration.BackColor = System.Drawing.Color.MintCream;
            this.cmbDuration.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Items.AddRange(new object[] {
            "Any",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbDuration.Location = new System.Drawing.Point(578, 329);
            this.cmbDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(108, 25);
            this.cmbDuration.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(575, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.Color.MintCream;
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txtKeyword.Location = new System.Drawing.Point(575, 224);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(138, 25);
            this.txtKeyword.TabIndex = 2;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(696, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "To";
            // 
            // btnViewWishlist
            // 
            this.btnViewWishlist.AllowDrop = true;
            this.btnViewWishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnViewWishlist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnViewWishlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnViewWishlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnViewWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewWishlist.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWishlist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewWishlist.Location = new System.Drawing.Point(796, 102);
            this.btnViewWishlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewWishlist.Name = "btnViewWishlist";
            this.btnViewWishlist.Size = new System.Drawing.Size(120, 42);
            this.btnViewWishlist.TabIndex = 1;
            this.btnViewWishlist.Text = "View Wishlist";
            this.btnViewWishlist.UseVisualStyleBackColor = false;
            this.btnViewWishlist.Click += new System.EventHandler(this.btnViewWishlist_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label7.Location = new System.Drawing.Point(572, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 35);
            this.label7.TabIndex = 20;
            this.label7.Text = "Filter Results";
            // 
            // flowLayoutPackages
            // 
            this.flowLayoutPackages.AutoScroll = true;
            this.flowLayoutPackages.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPackages.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPackages.Name = "flowLayoutPackages";
            this.flowLayoutPackages.Size = new System.Drawing.Size(511, 628);
            this.flowLayoutPackages.TabIndex = 0;
            this.flowLayoutPackages.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPackages_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.AllowDrop = true;
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Location = new System.Drawing.Point(776, 26);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 54);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Back to Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cmbSusScore
            // 
            this.cmbSusScore.BackColor = System.Drawing.Color.MintCream;
            this.cmbSusScore.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSusScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cmbSusScore.FormattingEnabled = true;
            this.cmbSusScore.Items.AddRange(new object[] {
            "Any",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbSusScore.Location = new System.Drawing.Point(939, 458);
            this.cmbSusScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSusScore.Name = "cmbSusScore";
            this.cmbSusScore.Size = new System.Drawing.Size(108, 25);
            this.cmbSusScore.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label8.Location = new System.Drawing.Point(935, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sustainability Score";
            // 
            // clbAccessibility
            // 
            this.clbAccessibility.BackColor = System.Drawing.Color.MintCream;
            this.clbAccessibility.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAccessibility.FormattingEnabled = true;
            this.clbAccessibility.HorizontalScrollbar = true;
            this.clbAccessibility.Items.AddRange(new object[] {
            "Gluten Free Meals",
            "Nut-Free Meals",
            "Sign Language",
            "Vegan Meals",
            "Wheelchair Access",
            "Wheelchair Availability"});
            this.clbAccessibility.Location = new System.Drawing.Point(918, 210);
            this.clbAccessibility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbAccessibility.Name = "clbAccessibility";
            this.clbAccessibility.Size = new System.Drawing.Size(435, 84);
            this.clbAccessibility.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label9.Location = new System.Drawing.Point(915, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Select all accessibilty options that match your needs";
            // 
            // btnCustomTrip
            // 
            this.btnCustomTrip.AllowDrop = true;
            this.btnCustomTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCustomTrip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnCustomTrip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCustomTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCustomTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomTrip.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomTrip.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomTrip.Location = new System.Drawing.Point(596, 102);
            this.btnCustomTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomTrip.Name = "btnCustomTrip";
            this.btnCustomTrip.Size = new System.Drawing.Size(164, 42);
            this.btnCustomTrip.TabIndex = 26;
            this.btnCustomTrip.Text = "Design Custom Trip";
            this.btnCustomTrip.UseVisualStyleBackColor = false;
            this.btnCustomTrip.Click += new System.EventHandler(this.btnCustomTrip_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.AllowDrop = true;
            this.btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBookings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnBookings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBookings.Location = new System.Drawing.Point(956, 102);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(136, 42);
            this.btnBookings.TabIndex = 27;
            this.btnBookings.Text = "View Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnTravelHistory
            // 
            this.btnTravelHistory.AllowDrop = true;
            this.btnTravelHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTravelHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnTravelHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTravelHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTravelHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTravelHistory.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTravelHistory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTravelHistory.Location = new System.Drawing.Point(1132, 102);
            this.btnTravelHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTravelHistory.Name = "btnTravelHistory";
            this.btnTravelHistory.Size = new System.Drawing.Size(163, 42);
            this.btnTravelHistory.TabIndex = 28;
            this.btnTravelHistory.Text = "View Travel History";
            this.btnTravelHistory.UseVisualStyleBackColor = false;
            this.btnTravelHistory.Click += new System.EventHandler(this.btnTravelHistory_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AllowDrop = true;
            this.btnProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProfile.Location = new System.Drawing.Point(573, 26);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(180, 54);
            this.btnProfile.TabIndex = 29;
            this.btnProfile.Text = "Manage Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label10.Location = new System.Drawing.Point(572, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "Search for packages made by a specific operator";
            // 
            // cmbOperator
            // 
            this.cmbOperator.BackColor = System.Drawing.Color.MintCream;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(575, 271);
            this.cmbOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(148, 24);
            this.cmbOperator.TabIndex = 32;
            this.cmbOperator.SelectedIndexChanged += new System.EventHandler(this.cmbOperator_SelectedIndexChanged);
            // 
            // btnReviews
            // 
            this.btnReviews.AllowDrop = true;
            this.btnReviews.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReviews.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnReviews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReviews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviews.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReviews.Location = new System.Drawing.Point(980, 26);
            this.btnReviews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(180, 54);
            this.btnReviews.TabIndex = 33;
            this.btnReviews.Text = "See Reviews";
            this.btnReviews.UseVisualStyleBackColor = false;
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label11.Location = new System.Drawing.Point(915, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Select all the activities you want in your itinerary";
            // 
            // clbActivities
            // 
            this.clbActivities.BackColor = System.Drawing.Color.MintCream;
            this.clbActivities.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbActivities.FormattingEnabled = true;
            this.clbActivities.HorizontalScrollbar = true;
            this.clbActivities.Items.AddRange(new object[] {
            "Hiking  ",
            "Luxury Tours  ",
            "Cultural Tours  ",
            "Cruise  ",
            "Shopping  ",
            "Museum Visit  ",
            "Historical Site Tour  ",
            "Food Street  ",
            "Local Market Visit  "});
            this.clbActivities.Location = new System.Drawing.Point(918, 322);
            this.clbActivities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbActivities.Name = "clbActivities";
            this.clbActivities.Size = new System.Drawing.Size(435, 84);
            this.clbActivities.TabIndex = 34;
            // 
            // btnReports
            // 
            this.btnReports.AllowDrop = true;
            this.btnReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReports.Location = new System.Drawing.Point(1182, 26);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(180, 54);
            this.btnReports.TabIndex = 36;
            this.btnReports.Text = "View Analytics/Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // travelerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(198)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1539, 628);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.clbActivities);
            this.Controls.Add(this.btnReviews);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnTravelHistory);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnCustomTrip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clbAccessibility);
            this.Controls.Add(this.cmbSusScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbTripType);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPackages);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewWishlist);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.cmbDuration);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGroupSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "travelerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "travelerHome";
            this.Load += new System.EventHandler(this.travelerHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGroupSize;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.ComboBox cmbTripType;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnViewWishlist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPackages;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmbSusScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbAccessibility;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCustomTrip;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnTravelHistory;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox clbActivities;
        private System.Windows.Forms.Button btnReports;
    }
}