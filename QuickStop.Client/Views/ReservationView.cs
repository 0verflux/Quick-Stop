using QuickStop.Client.Contracts.Views;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class ReservationForm : IReservationView
    {
        private event EventHandler CreateReservation;
        private event EventHandler UpdateReservation;

        event EventHandler IReservationView.CreateReservation
        {
            add { CreateReservation += value; }
            remove { CreateReservation -= value; }
        }

        event EventHandler IReservationView.UpdateReservation
        {
            add { UpdateReservation += value; }
            remove { UpdateReservation -= value; }
        }

        DialogResult IReservationView.ShowReservation(Hotel hotel, Reservation reservation)
        {
            Tag = hotel.ID;
            label7.Text = hotel.Name;
            label4.Text = hotel.Description;
            label10.Text = hotel.Location.ToString();
            label13.Text = "- -";

            return ShowDialog();
        }

        void IReservationView.FinalizeReservation(string reference)
        {
            DialogResult = MessageBox.Show("Thank you for booking!");
        }

        void IReservationView.RefreshView(Reservation reservation)
        {
            label13.Text = reservation.TotalCost.ToString("C2");
        }

        Reservation IReservationView.GetReservation()
        {
            return new Reservation
            {
                HotelID = Convert.ToInt32(Tag),
                GuestCount = (int)numericUpDown1.Value,
                CheckIn = dateTimePicker2.Value,
                CheckOut = dateTimePicker1.Value
            };
        }
    }
}
