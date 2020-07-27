using QuickStop.Client.Contracts;
using QuickStop.Domain.Models;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Views
{
    public interface IReservationView : IView
    {
        event EventHandler RequestCreateReservation;

        void DisplayReservation(Hotel hotel);
        void DisplayReservation(Reservation reservation, Hotel hotel);
        void FinalizeReservation(string reference);
        Reservation GetReservation();
    }
}
