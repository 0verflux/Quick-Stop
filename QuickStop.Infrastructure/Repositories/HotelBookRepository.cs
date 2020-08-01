using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Infrastructure.Repositories
{
    /// <summary>
    /// Provides data access of <see cref="HotelBook"/>.
    /// </summary>
    public sealed class HotelBookRepository : RepositoryBase, IHotelBookRepository
    {
        /// <summary>
        /// Initializes a new instance of <see cref="HotelBookRepository"/> provided with an <see cref="IHotelBookModelStream"/>.
        /// </summary>
        /// <param name="hotelBookModelStream">The stream used for accessing data.</param> 
        public HotelBookRepository(IHotelBookModelStream hotelBookModelStream) : base(hotelBookModelStream)
        {

        }

        void IHotelBookRepository.BookHotel(HotelBook reservation)
        {
            (modelStream as IHotelBookModelStream).CreateBookHotel(reservation);
        }

        HotelBook IHotelBookRepository.FindBookHotel(string reference)
        {
            return (modelStream as IHotelBookModelStream).FindBookHotel(reference);
        }
    }
}
