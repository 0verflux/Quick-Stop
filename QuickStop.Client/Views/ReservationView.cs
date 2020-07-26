using QuickStop.Client.Contracts.Views;
using QuickStop.Components;
using QuickStop.Domain.Models;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class ReservationForm : IReservationView
    {
        #region Events
        private event EventHandler RequestCreateReservation;

        event EventHandler IReservationView.RequestCreateReservation
        {
            add { RequestCreateReservation += value; }
            remove { RequestCreateReservation -= value; }
        }
        #endregion

        private Hotel hotel;
        private decimal price;

        void IReservationView.DisplayReservation(Hotel hotel)
        {
            this.hotel = hotel;
            label7.Text = hotel.Name;
            label4.Text = hotel.Description;
            label10.Text = hotel.Location.ToString();
            label13.Text = "Pick a number of guest!";
            ShowDialog();
        }

        void IReservationView.DisplayReservation(Reservation reservation, Hotel hotel)
        {
            label7.Text = hotel.Name;
            label4.Text = hotel.Description;
            label10.Text = hotel.Location.ToString();
            label13.Text = reservation.TotalCost.ToString("C2");
            numericUpDown1.Value = reservation.GuestCount;
            dateTimePicker2.Value = reservation.CheckIn;
            dateTimePicker1.Value = reservation.CheckOut;

            numericUpDown1.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            button1.Visible = false;
        }

        void IReservationView.FinalizeReservation(string reference)
        {
            MessageBox.Show("Thank you for booking in Quick Stop!\r\nYour booking reference is: " + reference, "Quick-Stop: Booking Complete", MessageBoxButtons.OK);
            Close();
        }

        Reservation IReservationView.GetReservation()
        {
            return new Reservation
            {
                Reference = ReferenceGenerator.Generate(6),
                HotelID = hotel.ID,
                GuestCount = (int)numericUpDown1.Value,
                CheckIn = dateTimePicker2.Value,
                CheckOut = dateTimePicker1.Value,
                TotalCost = price
            };
        }
    }
}
