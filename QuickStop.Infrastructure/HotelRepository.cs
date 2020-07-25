using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace QuickStop.Infrastructure
{
    public sealed class HotelRepository : RepositoryBase<Hotel>, IHotelRepository
    {
        private readonly IEnumerable<Hotel> hotels;

        public HotelRepository(string baseDirectory) : base(baseDirectory)
        {
            
        }

        IEnumerable<Hotel> IHotelRepository.Hotels => hotels;

        void IHotelRepository.UpdateHotelAvailability(int id, bool isUpdating)
        {
            // TODO: Implement method that changes hotel availability on call, kind of like a flip switch
            // checkout - checkin = duration of stay, hotel becomes available
            // isUpdating: makes hotel not available
        }

        void IHotelRepository.Save()
        {
            // TODO: Implement method that saves all hotels in text file.
        }

        Hotel IHotelRepository.FindHotelByID(int id)
        {
            return hotels.Where(x => x.ID == id).First();
        }
    }
}
