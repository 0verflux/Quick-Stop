using QuickStop.Client.ViewModels;
using QuickStop.Components.Helpers;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
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

            label7.DataBindings.Add("Text", ReservationViewModel, "HotelName", true, DataSourceUpdateMode.OnPropertyChanged);
            label4.DataBindings.Add("Text", ReservationViewModel, "HotelDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            label10.DataBindings.Add("Text", ReservationViewModel, "HotelLocation", true, DataSourceUpdateMode.OnPropertyChanged);
            label13.DataBindings.Add("Text", ReservationViewModel, "TotalCost", true, DataSourceUpdateMode.OnPropertyChanged, 0m, "C2");
            pictureBox1.DataBindings.Add("Image", ReservationViewModel, "HotelRoomImage", true, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDown1.DataBindings.Add("Minimum", ReservationViewModel, "MinimumGuestCount", false, DataSourceUpdateMode.OnPropertyChanged, 1);
            numericUpDown1.DataBindings.Add("Maximum", ReservationViewModel, "MaximumGuestCount", false, DataSourceUpdateMode.OnPropertyChanged, 100);
            numericUpDown1.DataBindings.Add("Value", ReservationViewModel, "GuestCount", false, DataSourceUpdateMode.OnPropertyChanged, 1);
            dateTimePicker1.DataBindings.Add("Value", ReservationViewModel, "CheckOut", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker2.DataBindings.Add("Value", ReservationViewModel, "CheckIn", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void NotifyInputChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = dateTimePicker2.Value.AddDays(1);

            if (ReservationViewModel == null) return;

            if((ReservationViewModel.TotalCost = HotelRoomBooking.CalculateTotalPrice(ReservationViewModel.Cost, ReservationViewModel.GuestCount, ReservationViewModel.MinimumGuestCount, ReservationViewModel.MaximumGuestCount, ReservationViewModel.CheckIn, ReservationViewModel.CheckOut)) == 0m)
            {
                label13.Text = "TeST";
            }
            
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
            ReservationViewModel.TotalCost = HotelRoomBooking.CalculateTotalPrice(ReservationViewModel.Cost, ReservationViewModel.GuestCount, ReservationViewModel.MinimumGuestCount, ReservationViewModel.MaximumGuestCount, ReservationViewModel.CheckIn, ReservationViewModel.CheckOut);
        }    
}
}
