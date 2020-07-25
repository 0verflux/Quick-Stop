using QuickStop.Domain.Models;
namespace QuickStop.Infrastructure.Contracts
{
    public interface IReservationSerializer : ISerializer
    {
        void CreateReservation(Reservation reservation);
        Reservation ReadReservation(string reference);
        bool ReservationExists(string reference);
    }
}
