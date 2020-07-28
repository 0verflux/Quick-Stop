using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Infrastructure.Repositories
{
    public sealed class HotelBookingRepository : RepositoryBase<HotelBook>, IHotelBookingRepository
    {
        public HotelBookingRepository(IHotelBookSerializer serializer) : base(serializer)
        {

        }

        void IHotelBookingRepository.BookHotel(HotelBook reservation)
        {
            (serializer as IHotelBookSerializer).CreateBookHotel(reservation);
        }

        HotelBook IHotelBookingRepository.FindBookHotel(string reference)
        {
            return (serializer as IHotelBookSerializer).FindBookHotel(reference);
        }

        bool IHotelBookingRepository.BookHotelExists(string reference)
        {
            return (serializer as IHotelBookSerializer).BookHotelExists(reference);
        }
    }
}
