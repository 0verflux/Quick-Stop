using QuickStop.Domain.Models;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IHotelSerializer : ISerializer
    { 
        IEnumerable<HotelRoom> DeserializeHotels();
        void SerializeHotels(IEnumerable<HotelRoom> hotels);
    }
}
