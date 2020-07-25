using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using System.Collections;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IHotelRepository
    {
        IEnumerable<Hotel> GetHotels(Location location, int guestCount, bool sortMode);

        void Save();
        Hotel FindHotelByID(int id);
    }
}
