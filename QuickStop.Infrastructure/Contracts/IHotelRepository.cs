using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using System.Collections;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IHotelRepository
    {
        IEnumerable<Hotel> GetHotels(Location location, int guestCount, Sort sort);

        void Save();
        Hotel FindHotelByID(int id);
    }
}
