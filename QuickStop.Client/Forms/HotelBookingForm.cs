using QuickStop.Client.ViewModels;
using QuickStop.Components.Helpers;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class HotelBookingForm : Form
    {
        public HotelBookingForm()
        {
            InitializeComponent();

            dateTimePicker2.MinDate = DateTime.Now;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            label7.DataBindings.Clear();
            label4.DataBindings.Clear();
            label10.DataBindings.Clear();
            label13.DataBindings.Clear();
            pictureBox1.DataBindings.Clear();
            numericUpDown1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker2.DataBindings.Clear();

            label7.DataBindings.Add("Text", HotelBookingViewModel, "HotelName", true, DataSourceUpdateMode.OnPropertyChanged);
            label4.DataBindings.Add("Text", HotelBookingViewModel, "HotelDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            label10.DataBindings.Add("Text", HotelBookingViewModel, "HotelLocation", true, DataSourceUpdateMode.OnPropertyChanged);
            label13.DataBindings.Add("Text", HotelBookingViewModel, "TotalCost", true, DataSourceUpdateMode.OnPropertyChanged, 0m, "C2");
            pictureBox1.DataBindings.Add("Image", HotelBookingViewModel, "HotelRoomImage", true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDown1.DataBindings.Add("Minimum", HotelBookingViewModel, "MinimumGuestCount", false, DataSourceUpdateMode.OnPropertyChanged, 1);
            numericUpDown1.DataBindings.Add("Maximum", HotelBookingViewModel, "MaximumGuestCount", false, DataSourceUpdateMode.OnPropertyChanged, 100);
            numericUpDown1.DataBindings.Add("Value", HotelBookingViewModel, "GuestCount", false, DataSourceUpdateMode.OnPropertyChanged, 1);
            dateTimePicker1.DataBindings.Add("Value", HotelBookingViewModel, "CheckOut", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker2.DataBindings.Add("Value", HotelBookingViewModel, "CheckIn", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void NotifyInputChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = dateTimePicker2.Value.AddDays(1);
        }

        private void GuestCountChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void BookOnClick(object sender, EventArgs e)
        {
            RequestCreateReservation?.Invoke(sender, e);
        }

        private void CalculateTotalCost()
        {
            HotelBookingViewModel.TotalCost = HotelRoomBooking.CalculateTotalPrice(HotelBookingViewModel.Cost, HotelBookingViewModel.GuestCount, HotelBookingViewModel.MinimumGuestCount, HotelBookingViewModel.MaximumGuestCount, HotelBookingViewModel.CheckIn, HotelBookingViewModel.CheckOut);
        }
    }
}
