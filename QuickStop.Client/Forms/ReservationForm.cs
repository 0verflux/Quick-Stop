using System;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void NotifyInputChanged(object sender, EventArgs e)
        {
            if (hotel == null) return;

            dateTimePicker1.MinDate = dateTimePicker2.Value.AddDays(1);

            if (numericUpDown1.Value == 0)
            {
                label13.Text = "Pick a number of guest!";
            }
            else
            {
                price = hotel.Price * ((int)numericUpDown1.Value - hotel.MinGuestCount + 1) * (dateTimePicker1.Value - dateTimePicker2.Value).Days;
                label13.Text = price.ToString("C2");
            }
        }

        private void BookOnClick(object sender, EventArgs e)
        {
            RequestCreateReservation?.Invoke(sender, e);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
