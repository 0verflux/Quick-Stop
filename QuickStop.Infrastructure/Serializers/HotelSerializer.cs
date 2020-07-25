﻿using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Infrastructure.Serializers
{
    public sealed class HotelSerializer : SerializerBase, IHotelSerializer
    {
        private readonly string fileName;

        public HotelSerializer(string baseDirectory) : base(baseDirectory, ',')
        {
            fileName = "HotelData";
        }

        IEnumerable<Hotel> IHotelSerializer.DeserializeHotels()
        {
            List<Hotel> hotels = new List<Hotel>();

            string file = Path.Combine(baseDirectory, fileName + extension);
            string[] data = File.ReadAllLines(file);
            
            foreach(string hotelData in data)
            {
                string[] hotelParams = parser.Split(hotelData);

                Hotel hotel = new Hotel
                {
                    ID = Convert.ToInt32(hotelParams[0]),
                    Name = hotelParams[1].Trim('\"'),
                    Description = hotelParams[2].Trim('\"'),
                    Price = Convert.ToDecimal(hotelParams[3]),
                    Ratings = Convert.ToUInt16(hotelParams[4]),
                    Location = (Location)Enum.Parse(typeof(Location), hotelParams[5]),
                    DateUntilAvailable = string.IsNullOrWhiteSpace(hotelParams[6]) ? null : (DateTime?)Convert.ToDateTime(hotelParams[6]),
                    Icon = hotelParams[7],
                    Room = hotelParams[8]
                };

                hotels.Add(hotel);
            }

            return hotels;
        }

        void IHotelSerializer.SerializeHotels(IEnumerable<Hotel> hotels)
        {
            StringBuilder sb = new StringBuilder();
            string file = Path.Combine(baseDirectory, fileName + extension);

            foreach (Hotel hotel in hotels)
            {
                sb.Append(IncludeDelimiter(hotel.ID.ToString()));
                sb.Append(IncludeDelimiter(hotel.Name, true));
                sb.Append(IncludeDelimiter(hotel.Description, true));
                sb.Append(IncludeDelimiter(hotel.Price.ToString()));
                sb.Append(IncludeDelimiter(hotel.Ratings.ToString()));
                sb.Append(IncludeDelimiter(hotel.Location.ToString()));
                sb.Append(IncludeDelimiter(hotel.DateUntilAvailable.ToString()));
                sb.Append(IncludeDelimiter(hotel.Icon));
                sb.Append(IncludeDelimiter(hotel.Room));
                sb.AppendLine();
            }

            File.WriteAllText(file, sb.ToString());
        }

        private string IncludeDelimiter(string str, bool ignoreDelimiterOnString = false)
        {
            string quote = ignoreDelimiterOnString ? "\"" : null;
            return $"{quote}{str}{quote}{delimiters.First()}";
        }
    }
}