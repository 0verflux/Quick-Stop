namespace QuickStop.Client.Views
{
    partial class MainForm
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
            this.HotelCardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.GuestCountPicker = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.QueryButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ReferenceTextBox = new System.Windows.Forms.TextBox();
            this.CheckBookingButton = new System.Windows.Forms.Button();
            this.ManilaLocationButton = new QuickStop.Client.Controls.RadioToggleButton();
            this.QuezonLocationButton = new QuickStop.Client.Controls.RadioToggleButton();
            this.BaguioLocationButton = new QuickStop.Client.Controls.RadioToggleButton();
            this.SanFernandoLocationButton = new QuickStop.Client.Controls.RadioToggleButton();
            this.SortByCostButton = new QuickStop.Client.Controls.RadioToggleButton();
            this.SortByRatingsButton = new QuickStop.Client.Controls.RadioToggleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestCountPicker)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // HotelCardPanel
            // 
            this.HotelCardPanel.AutoScroll = true;
            this.HotelCardPanel.AutoSize = true;
            this.HotelCardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HotelCardPanel.BackColor = System.Drawing.Color.OldLace;
            this.HotelCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HotelCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HotelCardPanel.Location = new System.Drawing.Point(0, 350);
            this.HotelCardPanel.Margin = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.HotelCardPanel.Name = "HotelCardPanel";
            this.HotelCardPanel.Size = new System.Drawing.Size(957, 345);
            this.HotelCardPanel.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.59218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.40782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.QueryButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 149);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 185);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::QuickStop.Client.Properties.Resources.locations1;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.14966F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.85034F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ManilaLocationButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.QuezonLocationButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BaguioLocationButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.SanFernandoLocationButton, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.51351F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.48649F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(637, 185);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 4);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(195)))), ((int)(((byte)(101)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(6);
            this.label4.Size = new System.Drawing.Size(637, 61);
            this.label4.TabIndex = 0;
            this.label4.Text = "LOCATIONS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(163)))), ((int)(((byte)(168)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.71777F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.28223F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.GuestCountPicker, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(637, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.18182F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(320, 126);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.SortByCostButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.SortByRatingsButton, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(314, 80);
            this.tableLayoutPanel4.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OldLace;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "SORT BY";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuestCountPicker
            // 
            this.GuestCountPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuestCountPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestCountPicker.Location = new System.Drawing.Point(206, 6);
            this.GuestCountPicker.Margin = new System.Windows.Forms.Padding(6);
            this.GuestCountPicker.Name = "GuestCountPicker";
            this.GuestCountPicker.ReadOnly = true;
            this.GuestCountPicker.Size = new System.Drawing.Size(108, 25);
            this.GuestCountPicker.TabIndex = 13;
            this.GuestCountPicker.TabStop = false;
            this.GuestCountPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OldLace;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "NUMBER OF GUESTS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QueryButton
            // 
            this.QueryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.QueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryButton.FlatAppearance.BorderSize = 0;
            this.QueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryButton.ForeColor = System.Drawing.Color.OldLace;
            this.QueryButton.Location = new System.Drawing.Point(637, 126);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(0);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(320, 59);
            this.QueryButton.TabIndex = 2;
            this.QueryButton.TabStop = false;
            this.QueryButton.Text = "QUERY";
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryHotels);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(237)))), ((int)(((byte)(213)))));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.HotelCardPanel, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.09705F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.16034F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.88326F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(957, 711);
            this.tableLayoutPanel5.TabIndex = 19;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackgroundImage = global::QuickStop.Client.Properties.Resources.logo_banner1;
            this.tableLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.ReferenceTextBox, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.CheckBookingButton, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.95935F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.04065F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(957, 149);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OldLace;
            this.label2.Location = new System.Drawing.Point(836, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Already booked? ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReferenceTextBox
            // 
            this.ReferenceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.ReferenceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReferenceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReferenceTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReferenceTextBox.Location = new System.Drawing.Point(839, 46);
            this.ReferenceTextBox.Name = "ReferenceTextBox";
            this.ReferenceTextBox.Size = new System.Drawing.Size(115, 20);
            this.ReferenceTextBox.TabIndex = 1;
            this.ReferenceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckBookingButton
            // 
            this.CheckBookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(66)))), ((int)(((byte)(60)))));
            this.CheckBookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBookingButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBookingButton.ForeColor = System.Drawing.Color.OldLace;
            this.CheckBookingButton.Location = new System.Drawing.Point(842, 75);
            this.CheckBookingButton.Margin = new System.Windows.Forms.Padding(6);
            this.CheckBookingButton.Name = "CheckBookingButton";
            this.CheckBookingButton.Size = new System.Drawing.Size(109, 23);
            this.CheckBookingButton.TabIndex = 2;
            this.CheckBookingButton.Text = "Check Booking";
            this.CheckBookingButton.UseVisualStyleBackColor = false;
            this.CheckBookingButton.Click += new System.EventHandler(this.ViewReservationByReference);
            // 
            // ManilaLocationButton
            // 
            this.ManilaLocationButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ManilaLocationButton.AutoSize = true;
            this.ManilaLocationButton.BackgroundImage = global::QuickStop.Client.Properties.Resources.manila1;
            this.ManilaLocationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ManilaLocationButton.Checked = true;
            this.ManilaLocationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManilaLocationButton.FlatAppearance.BorderSize = 0;
            this.ManilaLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ManilaLocationButton.Location = new System.Drawing.Point(12, 73);
            this.ManilaLocationButton.Margin = new System.Windows.Forms.Padding(12);
            this.ManilaLocationButton.Name = "ManilaLocationButton";
            this.ManilaLocationButton.Size = new System.Drawing.Size(135, 100);
            this.ManilaLocationButton.TabIndex = 1;
            this.ManilaLocationButton.TabStop = true;
            this.ManilaLocationButton.Tag = "Manila";
            this.ManilaLocationButton.UseVisualStyleBackColor = true;
            this.ManilaLocationButton.CheckedChanged += new System.EventHandler(this.SelectedLocationChanged);
            // 
            // QuezonLocationButton
            // 
            this.QuezonLocationButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.QuezonLocationButton.AutoSize = true;
            this.QuezonLocationButton.BackgroundImage = global::QuickStop.Client.Properties.Resources.quezon_city1;
            this.QuezonLocationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuezonLocationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuezonLocationButton.FlatAppearance.BorderSize = 0;
            this.QuezonLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.QuezonLocationButton.Location = new System.Drawing.Point(171, 73);
            this.QuezonLocationButton.Margin = new System.Windows.Forms.Padding(12);
            this.QuezonLocationButton.Name = "QuezonLocationButton";
            this.QuezonLocationButton.Size = new System.Drawing.Size(135, 100);
            this.QuezonLocationButton.TabIndex = 2;
            this.QuezonLocationButton.Tag = "Quezon";
            this.QuezonLocationButton.UseVisualStyleBackColor = true;
            this.QuezonLocationButton.CheckedChanged += new System.EventHandler(this.SelectedLocationChanged);
            // 
            // BaguioLocationButton
            // 
            this.BaguioLocationButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.BaguioLocationButton.AutoSize = true;
            this.BaguioLocationButton.BackgroundImage = global::QuickStop.Client.Properties.Resources.baguio1;
            this.BaguioLocationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BaguioLocationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaguioLocationButton.FlatAppearance.BorderSize = 0;
            this.BaguioLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BaguioLocationButton.Location = new System.Drawing.Point(330, 73);
            this.BaguioLocationButton.Margin = new System.Windows.Forms.Padding(12);
            this.BaguioLocationButton.Name = "BaguioLocationButton";
            this.BaguioLocationButton.Size = new System.Drawing.Size(129, 100);
            this.BaguioLocationButton.TabIndex = 3;
            this.BaguioLocationButton.Tag = "Baguio";
            this.BaguioLocationButton.UseVisualStyleBackColor = true;
            this.BaguioLocationButton.CheckedChanged += new System.EventHandler(this.SelectedLocationChanged);
            // 
            // SanFernandoLocationButton
            // 
            this.SanFernandoLocationButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SanFernandoLocationButton.AutoSize = true;
            this.SanFernandoLocationButton.BackgroundImage = global::QuickStop.Client.Properties.Resources.san_fernando1;
            this.SanFernandoLocationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SanFernandoLocationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SanFernandoLocationButton.FlatAppearance.BorderSize = 0;
            this.SanFernandoLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SanFernandoLocationButton.Location = new System.Drawing.Point(483, 73);
            this.SanFernandoLocationButton.Margin = new System.Windows.Forms.Padding(12);
            this.SanFernandoLocationButton.Name = "SanFernandoLocationButton";
            this.SanFernandoLocationButton.Size = new System.Drawing.Size(142, 100);
            this.SanFernandoLocationButton.TabIndex = 4;
            this.SanFernandoLocationButton.Tag = "SanFernando";
            this.SanFernandoLocationButton.UseVisualStyleBackColor = true;
            this.SanFernandoLocationButton.CheckedChanged += new System.EventHandler(this.SelectedLocationChanged);
            // 
            // SortByCostButton
            // 
            this.SortByCostButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SortByCostButton.AutoSize = true;
            this.SortByCostButton.BackColor = System.Drawing.Color.OldLace;
            this.SortByCostButton.Checked = true;
            this.SortByCostButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortByCostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByCostButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByCostButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(163)))), ((int)(((byte)(168)))));
            this.SortByCostButton.Location = new System.Drawing.Point(3, 24);
            this.SortByCostButton.Name = "SortByCostButton";
            this.SortByCostButton.Size = new System.Drawing.Size(151, 53);
            this.SortByCostButton.TabIndex = 16;
            this.SortByCostButton.TabStop = true;
            this.SortByCostButton.Tag = "Price";
            this.SortByCostButton.Text = "Cost (Lowest)";
            this.SortByCostButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SortByCostButton.UseVisualStyleBackColor = false;
            this.SortByCostButton.CheckedChanged += new System.EventHandler(this.SelectedSortChanged);
            // 
            // SortByRatingsButton
            // 
            this.SortByRatingsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SortByRatingsButton.AutoSize = true;
            this.SortByRatingsButton.BackColor = System.Drawing.Color.OldLace;
            this.SortByRatingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortByRatingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByRatingsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByRatingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(163)))), ((int)(((byte)(168)))));
            this.SortByRatingsButton.Location = new System.Drawing.Point(160, 24);
            this.SortByRatingsButton.Name = "SortByRatingsButton";
            this.SortByRatingsButton.Size = new System.Drawing.Size(151, 53);
            this.SortByRatingsButton.TabIndex = 17;
            this.SortByRatingsButton.Tag = "Rating";
            this.SortByRatingsButton.Text = "Ratings (Highest)";
            this.SortByRatingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SortByRatingsButton.UseVisualStyleBackColor = false;
            this.SortByRatingsButton.CheckedChanged += new System.EventHandler(this.SelectedSortChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(957, 711);
            this.Controls.Add(this.tableLayoutPanel5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Stop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestCountPicker)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button CheckBookingButton;
        private System.Windows.Forms.TextBox ReferenceTextBox;
        private System.Windows.Forms.FlowLayoutPanel HotelCardPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private Controls.RadioToggleButton SortByCostButton;
        private Controls.RadioToggleButton SortByRatingsButton;
        private System.Windows.Forms.NumericUpDown GuestCountPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private Controls.RadioToggleButton ManilaLocationButton;
        private Controls.RadioToggleButton QuezonLocationButton;
        private Controls.RadioToggleButton BaguioLocationButton;
        private Controls.RadioToggleButton SanFernandoLocationButton;
    }
}