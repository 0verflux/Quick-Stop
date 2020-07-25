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
            var file = Path.Combine(baseDirectory, fileName + extension);
            var hotels = new List<Hotel>();
            string[] hotelDatas = File.ReadAllText(file).Split(Environment.NewLine.ToCharArray());

            foreach(string hotelData in hotelDatas)
            {
                string[] hotelParams = hotelData.Split(delimiters);
                Hotel hotel = new Hotel
                {
                    ID = Convert.ToInt32(hotelParams[0]),
                    Name = hotelParams[1],
                    Description = hotelParams[2],
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
            var file = Path.Combine(baseDirectory, fileName + extension);
            var sb = new StringBuilder();
            var lim = delimiters.First();
            var quote = "\"";

            // TODO: replace sb with a singleton instance

            sb.Clear();
            foreach (Hotel hotel in hotels)
            {
                sb.Append(quote + hotel.ID.ToString() + quote + lim); // TODO: ignore delimiter reading in string
                sb.Append(hotel.Name + lim);
                sb.Append(quote + hotel.Description + quote + lim);
                sb.Append("" + lim); // TODO: Convert BITMAP to byte array
                sb.Append("" + lim);
                sb.Append(hotel.Price.ToString() + lim);
                sb.Append(hotel.Ratings.ToString() + lim);
                sb.Append(hotel.Location.ToString() + lim);
                sb.Append(hotel.DateUntilAvailable.ToString() + lim);
                sb.AppendLine();
            }

            File.WriteAllText(file, sb.ToString());
        }
    }
}
