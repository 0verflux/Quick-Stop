using QuickStop.Domain.Models;

namespace QuickStop.Infrastructure.Contracts
{
    /// <summary>
    /// Provides data access of <see cref="HotelBook"/> between the domain and <see cref="IModelStream"/>.
    /// </summary>
    public interface IHotelBookRepository
    {
        /// <summary>
        /// Books a selected <see cref="HotelRoom"/>.
        /// </summary>
        /// <param name="hotelBook">The data to be booked.</param>
        void BookHotel(HotelBook hotelBook);

        /// <summary>
        /// Finds a booked Hotel Room by reference.
        /// </summary>
        /// <param name="reference">The key used to find a booked Hotel.</param> 
        /// <returns><see cref="HotelBook"/></returns>
        HotelBook FindBookHotel(string reference);
    }
}
