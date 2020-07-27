using QuickStop.Client.Contracts;
using QuickStop.Client.ViewModels;
using QuickStop.Domain.Models;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Views
{
    public interface IReservationView : IView
    {
        event EventHandler RequestCreateReservation;

        ReservationViewModel ReservationViewModel { get; set; }

        void DisplayReservation(bool isReadOnly = false);
        void FinalizeReservation(string reference);
    }
}
