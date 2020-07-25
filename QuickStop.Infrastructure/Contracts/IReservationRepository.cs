using QuickStop.Domain.Models;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IReservationRepository
    {
        void CreateReservation(Reservation reservation);
        Reservation GetReservation(string reference);
        bool ReservationExists(string reference);
    }
}
