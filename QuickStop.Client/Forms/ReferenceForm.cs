using QuickStop.Client.Contracts.Views;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class ReferenceForm : Form, IReferenceView
    {
        public ReferenceForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Copy();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        void IReferenceView.DisplayBookingReference(string reference)
        {
            textBox1.Text = reference;

            ShowDialog();
        }
    }
}
