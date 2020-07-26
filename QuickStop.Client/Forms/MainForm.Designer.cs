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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.radioToggleButton1 = new QuickStop.Client.Controls.RadioToggleButton();
            this.radioToggleButton2 = new QuickStop.Client.Controls.RadioToggleButton();
            this.radioToggleButton3 = new QuickStop.Client.Controls.RadioToggleButton();
            this.radioToggleButton4 = new QuickStop.Client.Controls.RadioToggleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.radioToggleButton5 = new QuickStop.Client.Controls.RadioToggleButton();
            this.radioToggleButton6 = new QuickStop.Client.Controls.RadioToggleButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(587, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 53);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.QueryHotels);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 236);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(878, 282);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.59218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.40782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 156);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioToggleButton1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioToggleButton2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioToggleButton3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioToggleButton4, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 148);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 4);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(552, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioToggleButton1
            // 
            this.radioToggleButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToggleButton1.AutoSize = true;
            this.radioToggleButton1.Checked = true;
            this.radioToggleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioToggleButton1.Location = new System.Drawing.Point(3, 40);
            this.radioToggleButton1.MinimumSize = new System.Drawing.Size(138, 105);
            this.radioToggleButton1.Name = "radioToggleButton1";
            this.radioToggleButton1.Size = new System.Drawing.Size(138, 105);
            this.radioToggleButton1.TabIndex = 1;
            this.radioToggleButton1.TabStop = true;
            this.radioToggleButton1.Tag = "Manila";
            this.radioToggleButton1.Text = "Manila";
            this.radioToggleButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioToggleButton1.UseVisualStyleBackColor = true;
            this.radioToggleButton1.CheckedChanged += new System.EventHandler(this.SelectedLocationChanged);
            // 
            // radioToggleButton2
            // 
            this.radioToggleButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToggleButton2.AutoSize = true;
            this.radioToggleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioToggleButton2.Location = new System.Drawing.Point(147, 40);
            this.radioToggleButton2.MinimumSize = new System.Drawing.Size(138, 105);
            this.radioToggleButton2.Name = "radioToggleButton2";
            this.radioToggleButton2.Size = new System.Drawing.Size(138, 105);
            this.radioToggleButton2.TabIndex = 2;
            this.radioToggleButton2.Tag = "Quezon";
            this.radioToggleButton2.Text = "Quezon";
            this.radioToggleButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioToggleButton2.UseVisualStyleBackColor = true;
            this.radioToggleButton2.CheckedChanged += new System.EventHandler(this.SelectedLocationChanged);
            // 
            // radioToggleButton3
            // 
            this.radioToggleButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToggleButton3.AutoSize = true;
            this.radioToggleButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioToggleButton3.Location = new System.Drawing.Point(291, 40);
            this.radioToggleButton3.MinimumSize = new System.Drawing.Size(138, 105);
            this.radioToggleButton3.Name = "radioToggleButton3";
            this.radioToggleButton3.Size = new System.Drawing.Size(138, 105);
            this.radioToggleButton3.TabIndex = 3;
            this.radioToggleButton3.Tag = "Baguio";
            this.radioToggleButton3.Text = "Baguio";
            this.radioToggleButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioToggleButton3.UseVisualStyleBackColor = true;
            this.radioToggleButton3.CheckedChanged += new System.EventHandler(this.SelectedLocationChanged);
            // 
            // radioToggleButton4
            // 
            this.radioToggleButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToggleButton4.AutoSize = true;
            this.radioToggleButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioToggleButton4.Location = new System.Drawing.Point(435, 40);
            this.radioToggleButton4.MinimumSize = new System.Drawing.Size(138, 105);
            this.radioToggleButton4.Name = "radioToggleButton4";
            this.radioToggleButton4.Size = new System.Drawing.Size(138, 105);
            this.radioToggleButton4.TabIndex = 4;
            this.radioToggleButton4.Tag = "SanFernando";
            this.radioToggleButton4.Text = "San Fernando";
            this.radioToggleButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioToggleButton4.UseVisualStyleBackColor = true;
            this.radioToggleButton4.CheckedChanged += new System.EventHandler(this.SelectedLocationChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.71777F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.28223F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(587, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.18182F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 88);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.radioToggleButton5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.radioToggleButton6, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(281, 55);
            this.tableLayoutPanel4.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sort By";
            // 
            // radioToggleButton5
            // 
            this.radioToggleButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToggleButton5.AutoSize = true;
            this.radioToggleButton5.Checked = true;
            this.radioToggleButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioToggleButton5.Location = new System.Drawing.Point(3, 16);
            this.radioToggleButton5.Name = "radioToggleButton5";
            this.radioToggleButton5.Size = new System.Drawing.Size(134, 36);
            this.radioToggleButton5.TabIndex = 16;
            this.radioToggleButton5.TabStop = true;
            this.radioToggleButton5.Tag = "Price";
            this.radioToggleButton5.Text = "Cost (Lowest)";
            this.radioToggleButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioToggleButton5.UseVisualStyleBackColor = true;
            this.radioToggleButton5.CheckedChanged += new System.EventHandler(this.SelectedSortChanged);
            // 
            // radioToggleButton6
            // 
            this.radioToggleButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToggleButton6.AutoSize = true;
            this.radioToggleButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioToggleButton6.Location = new System.Drawing.Point(143, 16);
            this.radioToggleButton6.Name = "radioToggleButton6";
            this.radioToggleButton6.Size = new System.Drawing.Size(135, 36);
            this.radioToggleButton6.TabIndex = 17;
            this.radioToggleButton6.Tag = "Rating";
            this.radioToggleButton6.Text = "Ratings (Highest)";
            this.radioToggleButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioToggleButton6.UseVisualStyleBackColor = true;
            this.radioToggleButton6.CheckedChanged += new System.EventHandler(this.SelectedSortChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown2.Location = new System.Drawing.Point(182, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number of Guests";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(884, 521);
            this.tableLayoutPanel5.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 65);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.tableLayoutPanel5);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Stop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private Controls.RadioToggleButton radioToggleButton1;
        private Controls.RadioToggleButton radioToggleButton2;
        private Controls.RadioToggleButton radioToggleButton3;
        private Controls.RadioToggleButton radioToggleButton4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private Controls.RadioToggleButton radioToggleButton5;
        private Controls.RadioToggleButton radioToggleButton6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}