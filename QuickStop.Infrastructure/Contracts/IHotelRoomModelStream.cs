using QuickStop.Domain.Models;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Contracts
{
    /// <summary>
    /// Represents a Model Stream for reading and writing <see cref="HotelRoom"/> in a Text File.
    /// </summary>
    public interface IHotelRoomModelStream : IModelStream
    {
        /// <summary>
        /// Reads all <see cref="HotelRoom"/> data in the Text File.
        /// </summary>
        /// <returns>A Collection of <see cref="HotelRoom"/>.</returns>
        IEnumerable<HotelRoom> ReadAllHotels();

        /// <summary>
        /// Writes all <see cref="HotelRoom"/> data in the Text File.
        /// </summary>
        /// <param name="hotels">A Collection of <see cref="HotelRoom"/>.</param> 
        void WriteAllHotels(IEnumerable<HotelRoom> hotels);
    }
}