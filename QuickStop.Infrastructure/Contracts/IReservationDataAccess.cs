using QuickStop.Domain.Models;
namespace QuickStop.Infrastructure.Contracts
{
    public interface IReservationSerializer : ISerializer
    {
        void CreateReservation(HotelBook reservation);
        HotelBook ReadReservation(string reference);
        bool ReservationExists(string reference);
    }
}
