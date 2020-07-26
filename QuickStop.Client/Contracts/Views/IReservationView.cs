using QuickStop.Client.Contracts;
using QuickStop.Domain.Models;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Views
{
    public interface IReservationView : IView
    {
        event EventHandler CreateReservation;
        event EventHandler UpdateReservation;

        Reservation GetReservation();

        DialogResult ShowReservation(Hotel hotel, Reservation reservation);
        void RefreshView(Reservation reservation);
        void FinalizeReservation(string reference);
    }
}
