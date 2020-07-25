using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickStop.Infrastructure.Repositories
{
    public sealed class HotelRepository : RepositoryBase<Hotel>, IHotelRepository
    {
        private readonly IEnumerable<Hotel> hotels;

        public HotelRepository(ISerializer serializer) : base(serializer)
        {
            hotels = (serializer as IHotelSerializer).DeserializeHotels();
        }

        IEnumerable<Hotel> IHotelRepository.GetHotels(Location location, int guestCount, bool sortMode)
        {
            var list = hotels.Where(x => x.Location == location);

            if (guestCount > 0)
            {
                list = list.Where(x => x.MinGuestCount >= guestCount && x.MaxGuestCount <= guestCount);
            }

            if(sortMode)
            {
                return list.OrderByDescending(x => x.Price);
            }
            else
            {
                return list.OrderBy(x => x.Ratings);
            }
        }

        void IHotelRepository.Save()
        {
            (serializer as IHotelSerializer).SerializeHotels(hotels);
        }

        Hotel IHotelRepository.FindHotelByID(int id)
        {
            return hotels.Where(x => x.ID == id).First();
        }
    }
}
