using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickStop.Infrastructure.Repositories
{
    public sealed class HotelRepository : RepositoryBase<HotelRoom>, IHotelRepository
    {
        private IEnumerable<HotelRoom> hotels;

        public HotelRepository(ISerializer serializer) : base(serializer)
        {
            hotels = (serializer as IHotelSerializer).DeserializeHotels();
        }

        IEnumerable<HotelRoom> IHotelRepository.GetHotels(Location location, int guestCount, Sort sort)
        {
            var list = hotels.Where(x => x.IsAvailable).Where(x => x.Location == location);

            if (guestCount > 0)
            {
                list = list.Where(x => guestCount >= x.MinGuestCount && guestCount <= x.MaxGuestCount);
            }

            switch(sort)
            {
                case Sort.Price: return list.OrderByDescending(x => x.Ratings).OrderBy(x => x.Price);
                case Sort.Rating: return list.OrderBy(x => x.Price).OrderByDescending(x => x.Ratings);
                default: return list;
            }
        }

        void IHotelRepository.Save()
        {
            (serializer as IHotelSerializer).SerializeHotels(hotels);
        }

        HotelRoom IHotelRepository.FindHotelByID(int id)
        {
            return hotels.Where(x => x.ID == id).First();
        }

        void IHotelRepository.SetHotelInavailablity(int id, DateTime dateTime)
        {
            var newHotels = hotels.ToList();

            for(int i = 0; i < newHotels.Count; i++)
            {
                if(newHotels[i].ID == id)
                {
                    newHotels[i].DateUntilAvailable = (DateTime?)dateTime;

                    hotels = newHotels;
                    return;
                }
            }
        }
    }
}
