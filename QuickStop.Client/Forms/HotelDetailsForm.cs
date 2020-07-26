using System;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class HotelDetailsForm : Form
    {
        public HotelDetailsForm()
        {
            InitializeComponent();
        }

        private void BookHotelOnClick(object sender, EventArgs e)
        {
            Hide();
            Close();
            RequestReservation?.Invoke(sender, new Components.HotelSelectedEventArgs(Convert.ToInt32(Tag)));
        }
    }
}
