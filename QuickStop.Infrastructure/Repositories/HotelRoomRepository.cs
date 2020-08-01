using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickStop.Infrastructure.Repositories
{
    /// <summary>
    /// Provides data access of <see cref="HotelRoom"/>.
    /// </summary>
    public sealed class HotelRoomRepository : RepositoryBase, IHotelRoomRepository
    {
        private IEnumerable<HotelRoom> hotels;

        /// <summary>
        /// Initializes a new instance of <see cref="HotelRoomRepository"/> provided with an <see cref="IHotelSerializer"/>.
        /// </summary>
        /// <param name="serializer">The serializer used for accessing data.</param> 
        public HotelRoomRepository(IHotelSerializer serializer) : base(serializer)
        {
            hotels = (base.serializer as IHotelSerializer).DeserializeHotels();
        }

        IEnumerable<HotelRoom> IHotelRoomRepository.GetHotels(Location location, int guestCount, Sort sort)
        {
            // Filter the List only if it is Available
            // Then Filter the List by Location
            var list = hotels.Where(x => x.IsAvailable).Where(x => x.Location == location);

            // Filter guestCount by its range if it is more than 0
            if (guestCount > 0)
            {
                list = list.Where(x => guestCount >= x.MinGuestCount && guestCount <= x.MaxGuestCount);
            }


            switch (sort)
            {
                //Sort by Ratings First from High to Low, then by Price from Low to High
                case Sort.Price: return list.OrderByDescending(x => x.Ratings).OrderBy(x => x.Price);

                //Sort by Price first from Low to High, then by Ratings from High to Low
                case Sort.Rating: return list.OrderBy(x => x.Price).OrderByDescending(x => x.Ratings);
                default: return list;
            }
        }

        void IHotelRoomRepository.Save()
        {
            (serializer as IHotelSerializer).SerializeHotels(hotels);
        }

        HotelRoom IHotelRoomRepository.FindHotelByID(int id)
        {
            return hotels.Where(x => x.ID == id).First();
        }

        void IHotelRoomRepository.SetHotelInavailablity(int id, DateTime dateTime)
        {
            var newHotel = hotels.ToList();
            var index = newHotel.FindIndex(x => x.ID == id);

            var oldData = newHotel[index];
            var newData = new HotelRoom
            {
                ID = oldData.ID,
                Name = oldData.Name,
                Description = oldData.Description,
                Price = oldData.Price,
                Ratings = oldData.Ratings,
                Location = oldData.Location,
                MinGuestCount = oldData.MinGuestCount,
                MaxGuestCount = oldData.MaxGuestCount,
                DateUntilAvailable = dateTime,
                Icon = oldData.Icon,
                Room = oldData.Room
            };

            newHotel[index] = newData;

            hotels = newHotel;
        }
    }
}