using QuickStop.Client.Contracts.Views;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Views
{
    public partial class ReservationForm : IReservationView
    {
        private event EventHandler CreateReservation;
        private event EventHandler UpdateTotalCost;
        private Reservation reservation;

        event EventHandler IReservationView.CreateReservation
        {
            add { CreateReservation += value; }
            remove { CreateReservation -= value; }
        }

        event EventHandler IReservationView.UpdateTotalCost
        {
            add { UpdateTotalCost += value; }
            remove { UpdateTotalCost -= value; }
        }

        void IReservationView.ShowReservation(Hotel hotel, Reservation reservation)
        {
            // TODO: Fill Up Reservation Info

            ShowDialog();
        }

        void IReservationView.FinalizeReservation()
        {
            // TODO: Confirm Message
        }

        Reservation IReservationView.GetReservation()
        {
            return reservation;
        }
    }
}
