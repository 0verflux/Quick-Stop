using QuickStop.Client.Controls;
using QuickStop.Components.CustomEventArgs;
using QuickStop.Domain.Enums;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void QueryHotels(object sender, EventArgs e)
        {
            RequestLoadHotels?.Invoke(sender, new HotelFilterEventArgs(selectedLocation, (int)numericUpDown2.Value, sort));
        }

        private void ViewSelectedHotel(object sender, HotelSelectedEventArgs e)
        {
            RequestViewHotelDetails?.Invoke(sender, e);
            QueryHotels(sender, e);
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            RequestSaveData?.Invoke(sender, e);
        }

        private void SelectedLocationChanged(object sender, EventArgs e)
        {
            var btn = sender as RadioToggleButton;

            if (btn.Checked)
            {
                selectedLocation = (Location)Enum.Parse(typeof(Location), btn.Tag.ToString());
            }
        }

        private void SelectedSortChanged(object sender, EventArgs e)
        {
            var btn = sender as RadioToggleButton;

            if (btn.Checked)
            {
                sort = (Sort)Enum.Parse(typeof(Sort), btn.Tag.ToString());
            }
        }

        private void ViewReservationByReference(object sender, EventArgs e)
        {
            RequestViewReservation?.Invoke(sender, new ReservationReferenceEventArgs(textBox1.Text));
        }
    }
}
