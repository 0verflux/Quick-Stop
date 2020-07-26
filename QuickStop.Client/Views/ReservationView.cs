using QuickStop.Client.Contracts;
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
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            numericUpDown1.Value = 1;

            this.hotel = hotel;
            label7.Text = hotel.Name;
            label4.Text = hotel.Description;
            label10.Text = hotel.Location.ToString();
            label13.Text = "Pick a number of guest!";
            pictureBox1.Image = hotel.Room.ConvertToImage();
            numericUpDown1.Minimum = hotel.MinGuestCount;
            numericUpDown1.Maximum = hotel.MaxGuestCount;

            numericUpDown1.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            button1.Visible = true;
            ShowDialog();
        }

        void IReservationView.DisplayReservation(Reservation reservation, Hotel hotel)
        {
            this.hotel = null;
            dateTimePicker2.MinDate = DateTimePicker.MinimumDateTime;
            dateTimePicker1.MinDate = DateTimePicker.MinimumDateTime;

            label7.Text = hotel.Name;
            label4.Text = hotel.Description;
            label10.Text = hotel.Location.ToString();
            label13.Text = reservation.TotalCost.ToString("C2");
            numericUpDown1.Value = reservation.GuestCount;
            dateTimePicker2.Value = reservation.CheckIn;
            dateTimePicker1.Value = reservation.CheckOut;
            pictureBox1.Image = hotel.Room.ConvertToImage();
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 100;

            numericUpDown1.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            button1.Visible = false;
            ShowDialog();
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
