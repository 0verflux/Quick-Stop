using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IHotelSerializer : ISerializer
    { 
        IEnumerable<HotelRoom> DeserializeHotels();
        void SerializeHotels(IEnumerable<HotelRoom> hotels);
    }
}
