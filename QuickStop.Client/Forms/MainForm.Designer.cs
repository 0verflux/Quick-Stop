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
            this.radioToggleButton1 = new QuickStop.Client.Controls.RadioToggleButton();
            this.radioToggleButton2 = new QuickStop.Client.Controls.RadioToggleButton();
            this.SuspendLayout();
            // 
            // radioToggleButton1
            // 
            this.radioToggleButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToggleButton1.AutoSize = true;
            this.radioToggleButton1.Checked = true;
            this.radioToggleButton1.Location = new System.Drawing.Point(142, 177);
            this.radioToggleButton1.Name = "radioToggleButton1";
            this.radioToggleButton1.Size = new System.Drawing.Size(110, 23);
            this.radioToggleButton1.TabIndex = 0;
            this.radioToggleButton1.TabStop = true;
            this.radioToggleButton1.Text = "radioToggleButton1";
            this.radioToggleButton1.UseVisualStyleBackColor = true;
            // 
            // radioToggleButton2
            // 
            this.radioToggleButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToggleButton2.AutoSize = true;
            this.radioToggleButton2.Location = new System.Drawing.Point(168, 237);
            this.radioToggleButton2.Name = "radioToggleButton2";
            this.radioToggleButton2.Size = new System.Drawing.Size(110, 23);
            this.radioToggleButton2.TabIndex = 1;
            this.radioToggleButton2.Text = "radioToggleButton2";
            this.radioToggleButton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 537);
            this.Controls.Add(this.radioToggleButton2);
            this.Controls.Add(this.radioToggleButton1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.RadioToggleButton radioToggleButton1;
        private Controls.RadioToggleButton radioToggleButton2;
    }
}