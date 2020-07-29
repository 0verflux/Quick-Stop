using QuickStop.Domain.Models;

namespace QuickStop.Infrastructure.Contracts
{
    /// <summary>
    /// Represents a Reader and Writer for <see cref="HotelBook"/>.
    /// </summary>
    public interface IHotelBookSerializer : ISerializer
    {
        /// <summary>
        /// Creates a new Booked Hotel Room. 
        /// </summary>
        /// <param name="reservation">The data to be stored.</param>
        void CreateBookHotel(HotelBook hotelBook);

        /// <summary>
        /// Finds all Booked Hotel Room by reference key.
        /// </summary>
        /// <param name="reference">The key to be searched with.</param>
        /// <returns><see cref="HotelBook"/></returns> 
        HotelBook FindBookHotel(string reference);

        /// <summary>
        /// Checks if a Booked Hotel Room Exists.
        /// </summary>
        /// <param name="reference">The key to be searched with.</param>
        /// <returns><see langword="true"/> if Booked Hotel Room Exists, otherwise <see langword="false"/>.</returns>
        bool BookHotelExists(string reference);
    }
}
