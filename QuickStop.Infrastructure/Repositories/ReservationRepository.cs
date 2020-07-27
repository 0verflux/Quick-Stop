using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Infrastructure.Repositories
{
    public sealed class ReservationRepository : RepositoryBase<HotelBook>, IReservationRepository
    {
        public ReservationRepository(ISerializer serializer) : base(serializer)
        {

        }

        void IReservationRepository.CreateReservation(HotelBook reservation)
        {
            (serializer as IReservationSerializer).CreateReservation(reservation);
        }

        HotelBook IReservationRepository.GetReservation(string reference)
        {
            return (serializer as IReservationSerializer).ReadReservation(reference);
        }

        bool IReservationRepository.ReservationExists(string reference)
        {
            return (serializer as IReservationSerializer).ReservationExists(reference);
        }
    }
}
