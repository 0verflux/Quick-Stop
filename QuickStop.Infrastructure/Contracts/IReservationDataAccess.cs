using QuickStop.Domain.Models;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IReservationDataAccess : IDataAccess<Reservation>
    {
        void CreateReservation(Reservation reservation);
    }
}
