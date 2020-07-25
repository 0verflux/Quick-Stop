using QuickStop.Client.Contracts;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Views
{
    public interface IReservationView : IView
    {
        event EventHandler CreateReservation;
        event EventHandler UpdateTotalCost;

        Reservation GetReservation();

        void ShowReservation(Hotel hotel, Reservation reservation);
        void FinalizeReservation();
    }
}
