using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Infrastructure.Repositories
{
    /// <summary>
    /// Provides data access of <see cref="HotelBook"/>.
    /// </summary>
    public sealed class HotelBookingRepository : RepositoryBase<HotelBook>, IHotelBookingRepository
    {
        /// <summary>
        /// Initializes a new instance of <see cref="HotelBookingRepository"/> provided with an <see cref="IHotelBookSerializer"/>.
        /// </summary>
        /// <param name="serializer">The serializer used for accessing data.</param> 
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
