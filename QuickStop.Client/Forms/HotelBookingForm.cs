using QuickStop.Client.DTO;
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

            CheckInDatePicker.MinDate = DateTime.Now;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            HotelRoomName.DataBindings.Clear();
            HotelRoomDescription.DataBindings.Clear();
            HotelRoomLocation.DataBindings.Clear();
            HotelRoomTotalCost.DataBindings.Clear();
            HotelRoomImage.DataBindings.Clear();
            GuestCountPicker.DataBindings.Clear();
            CheckOutDatePicker.DataBindings.Clear();
            CheckInDatePicker.DataBindings.Clear();

            HotelRoomName.DataBindings.Add("Text", HotelBookDTO, "HotelName", true, DataSourceUpdateMode.OnPropertyChanged);
            HotelRoomDescription.DataBindings.Add("Text", HotelBookDTO, "HotelDescription", true, DataSourceUpdateMode.OnPropertyChanged);
            HotelRoomLocation.DataBindings.Add("Text", HotelBookDTO, "HotelLocation", true, DataSourceUpdateMode.OnPropertyChanged);
            HotelRoomTotalCost.DataBindings.Add("Text", HotelBookDTO, "TotalCost", true, DataSourceUpdateMode.OnPropertyChanged, 0m, "C2");
            HotelRoomImage.DataBindings.Add("Image", HotelBookDTO, "HotelRoomImage", true, DataSourceUpdateMode.OnPropertyChanged);
            GuestCountPicker.DataBindings.Add("Minimum", HotelBookDTO, "MinimumGuestCount", false, DataSourceUpdateMode.OnPropertyChanged, 1);
            GuestCountPicker.DataBindings.Add("Maximum", HotelBookDTO, "MaximumGuestCount", false, DataSourceUpdateMode.OnPropertyChanged, 100);
            GuestCountPicker.DataBindings.Add("Value", HotelBookDTO, "GuestCount", false, DataSourceUpdateMode.OnPropertyChanged, 1);
            CheckOutDatePicker.DataBindings.Add("Value", HotelBookDTO, "CheckOut", true, DataSourceUpdateMode.OnPropertyChanged);
            CheckInDatePicker.DataBindings.Add("Value", HotelBookDTO, "CheckIn", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void UpdateDatePickerMinimumDate(object sender, EventArgs e)
        {
            CheckOutDatePicker.MinDate = CheckInDatePicker.Value.AddDays(1);
        }

        private void NotifyInputChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
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
            HotelBookDTO.TotalCost = HotelRoomBooking.CalculateTotalCost(HotelBookDTO.Cost, HotelBookDTO.GuestCount, HotelBookDTO.MinimumGuestCount, HotelBookDTO.MaximumGuestCount, HotelBookDTO.CheckIn, HotelBookDTO.CheckOut);
        }

        
    }
}
