using QuickStop.Domain.Models;
using System.Collections;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IHotelRepository
    {
        IEnumerable<Hotel> Hotels { get; }

        void UpdateHotelAvailability(int id, bool isUpdating);
        void Save();
        Hotel FindHotelByID(int id);
    }
}
