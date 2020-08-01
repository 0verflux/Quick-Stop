using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Contracts
{
    /// <summary>
    /// Provides data access of <see cref="HotelRoom"/> between the domain and <see cref="IModelStream"/>.
    /// </summary>
    public interface IHotelRoomRepository
    {
        /// <summary>
        /// Retrieves all collection of <see cref="HotelRoom"/> provided with the given filters.
        /// </summary>
        /// <param name="location">The <see cref="Location"/> to filter the <see cref="HotelRoom"/>.</param>
        /// <param name="guestCount">The guest count to filter the <see cref="HotelRoom"/>.</param>
        /// <param name="sort">The  <see cref="Sort"/> type to sort the <see cref="HotelRoom"/>.</param>
        /// <returns>A filtered collection of <see cref="HotelRoom"/>.</returns> 
        IEnumerable<HotelRoom> GetHotels(Location location, int guestCount, Sort sort);

        /// <summary>
        /// Saves all Collection of <see cref="HotelRoom"/>.
        /// </summary>
        void Save();

        /// <summary>
        /// Retrieves a <see cref="HotelRoom"/> provided with an ID.
        /// </summary>
        /// <param name="id">The ID to search a <see cref="HotelRoom"/>.</param>
        /// <returns><see cref="HotelRoom"/></returns>
        HotelRoom FindHotelByID(int id);

        /// <summary>
        /// Sets a <see cref="HotelRoom"/> by disabling its availability until it reaches at a certain date.
        /// </summary>
        /// <param name="id">The ID to modify the <see cref="HotelRoom"/>.</param>
        /// <param name="dateTime">The Date until the <see cref="HotelRoom"/> becomes available again.</param>
        void SetHotelInavailablity(int id, DateTime dateTime);
    }
}
