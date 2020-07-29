using QuickStop.Domain.Models;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Contracts
{
    /// <summary>
    /// Represents a Serializer for reading and writing <see cref="HotelRoom"/> in a Text File.
    /// </summary>
    public interface IHotelSerializer : ISerializer
    {
        /// <summary>
        /// Reads all <see cref="HotelRoom"/> data in the Text File.
        /// </summary>
        /// <returns>A Collection of <see cref="HotelRoom"/>.</returns>
        IEnumerable<HotelRoom> DeserializeHotels();

        /// <summary>
        /// Writes all <see cref="HotelRoom"/> data in the Text File.
        /// </summary>
        /// <param name="hotels">A Collection of <see cref="HotelRoom"/>.</param>
        void SerializeHotels(IEnumerable<HotelRoom> hotels);
    }
}