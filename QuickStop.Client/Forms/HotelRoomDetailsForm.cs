using QuickStop.Components.CustomEventArgs;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class HotelRoomDetailsForm : Form
    {
        public HotelRoomDetailsForm()
        {
            InitializeComponent();
        }

        private void BookHotelOnClick(object sender, EventArgs e)
        {
            Hide();
            Close();
            RequestReservation?.Invoke(sender, new HotelSelectedEventArgs(Convert.ToInt32(Tag)));
        }
    }
}
