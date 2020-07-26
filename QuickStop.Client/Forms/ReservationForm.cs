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
            dateTimePicker1.MinDate = dateTimePicker2.Value.AddDays(1);

            if (numericUpDown1.Value == 0)
            {
                label13.Text = "Pick a number of guest!";
            }
            else
            {
                price = hotel.Price * numericUpDown1.Value * (dateTimePicker1.Value - dateTimePicker2.Value).Days;
                label13.Text = price.ToString("C2");
            }
        }

        private void BookOnClick(object sender, EventArgs e)
        {
            RequestCreateReservation?.Invoke(sender, e);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
        }
    }
}
