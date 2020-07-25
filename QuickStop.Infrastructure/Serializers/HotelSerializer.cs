using QuickStop.Domain.Enums;
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
                    Name = hotelParams[1].Trim('\'', '\"'),
                    Description = hotelParams[2].Trim('\'', '\"'),
                    Icon = null, // TODO: parse string to bitmap
                    Room = null,
                    Price = Convert.ToDecimal(hotelParams[5]),
                    Ratings = Convert.ToUInt16(hotelParams[6]),
                    Location = (Location)Enum.Parse(typeof(Location), hotelParams[7]),
                    DateUntilAvailable = Convert.ToDateTime(hotelParams[8])
                };

                hotels.Add(hotel);
            }

            return hotels;
        }

        void IHotelSerializer.SerializeHotels(IEnumerable<Hotel> hotels)
        {
            StringBuilder sb = new StringBuilder();
            string file = Path.Combine(baseDirectory, fileName + extension);
            string quote = "\"";

            foreach (Hotel hotel in hotels)
            {
                sb.Append(IncludeDelimiter(quote + hotel.ID.ToString() + quote));
                sb.Append(IncludeDelimiter(hotel.Name));
                sb.Append(IncludeDelimiter(quote + hotel.Description + quote));
                sb.Append(IncludeDelimiter("")); // TODO: Convert BITMAP to byte array
                sb.Append(IncludeDelimiter(""));
                sb.Append(IncludeDelimiter(hotel.Price.ToString()));
                sb.Append(IncludeDelimiter(hotel.Ratings.ToString()));
                sb.Append(IncludeDelimiter(hotel.Location.ToString()));
                sb.Append(IncludeDelimiter(hotel.DateUntilAvailable.ToString()));
                sb.AppendLine();
            }

            File.WriteAllText(file, sb.ToString());
        }

        private string IncludeDelimiter(string str)
        {
            return str + delimiters.First();
        }
    }
}
