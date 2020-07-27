using QuickStop.Domain.Models;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IReservationRepository
    {
        void CreateReservation(HotelBook reservation);
        HotelBook GetReservation(string reference);
        bool ReservationExists(string reference);
    }
}
