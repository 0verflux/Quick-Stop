using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace QuickStop.Infrastructure.Serializers
{
    /// <summary>
    /// Represents a Reader and Writer for <see cref="HotelRoom"/>.
    /// </summary>
    public sealed class HotelSerializer : SerializerBase, IHotelSerializer 
    {
        private readonly string fileName;

        /// <summary>
        /// Initializes a new Instance of <see cref="HotelSerializer"/>.
        /// </summary>
        /// <param name="baseDirectory">The base directory of the file.</param>
        public HotelSerializer(string baseDirectory) : base(baseDirectory, @"\Data\", ',')
        {
            fileName = "HotelData";
        }

        IEnumerable<HotelRoom> IHotelSerializer.DeserializeHotels()
        {
            List<HotelRoom> hotels = new List<HotelRoom>();

            string file = FilePath(fileName);

            // Check if File Exists
            // If no file is found, a new file is made.
            if(!File.Exists(file))
            {
                string src = GetResourceFileContentAsString(fileName + extension);
                File.WriteAllText(file, src);
            }

            // Reads all data per line in the file.
            string[] data = File.ReadAllLines(file);

            foreach (string hotelData in data)
            {
                // splits all data by a delimiter.
                string[] hotelParams = parser.Split(hotelData);

                try
                {
                    HotelRoom hotel = new HotelRoom
                    {
                        ID = Convert.ToInt32(hotelParams[0]),
                        Name = hotelParams[1].Trim('\"'),
                        Description = hotelParams[2].Trim('\"'),
                        Price = Convert.ToDecimal(hotelParams[3]),
                        Ratings = Convert.ToUInt16(hotelParams[4]),
                        Location = (Location)Enum.Parse(typeof(Location), hotelParams[5]),
                        MinGuestCount = Convert.ToInt32(hotelParams[6]),
                        MaxGuestCount = Convert.ToInt32(hotelParams[7]),
                        DateUntilAvailable = string.IsNullOrWhiteSpace(hotelParams[8]) ? null : (DateTime?)Convert.ToDateTime(hotelParams[8]),
                        Icon = hotelParams[9],
                        Room = hotelParams[10]
                    };

                    hotels.Add(hotel);
                }
                catch
                {

                }
            }

            return hotels;
        }

        void IHotelSerializer.SerializeHotels(IEnumerable<HotelRoom> hotels)
        {

            StringBuilder sb = new StringBuilder();
            string file = FilePath(fileName);

            foreach (HotelRoom hotel in hotels)
            {
                sb.Append(IncludeDelimiter(hotel.ID.ToString()));
                sb.Append(IncludeDelimiter(hotel.Name, true));
                sb.Append(IncludeDelimiter(hotel.Description, true));
                sb.Append(IncludeDelimiter(hotel.Price.ToString()));
                sb.Append(IncludeDelimiter(hotel.Ratings.ToString()));
                sb.Append(IncludeDelimiter(hotel.Location.ToString()));
                sb.Append(IncludeDelimiter(hotel.MinGuestCount.ToString()));
                sb.Append(IncludeDelimiter(hotel.MaxGuestCount.ToString()));
                sb.Append(IncludeDelimiter(hotel.DateUntilAvailable.ToString()));
                sb.Append(IncludeDelimiter(hotel.Icon));
                sb.Append(IncludeDelimiter(hotel.Room));
                sb.AppendLine();
            }

            // Write all collection of hotels in the text file.
            File.WriteAllText(file, sb.ToString());
        }

        private string IncludeDelimiter(string str, bool ignoreDelimiterOnString = false)
        {
            string quote = ignoreDelimiterOnString ? "\"" : null;
            return $"{quote}{str}{quote}{delimiters.First()}";
        }

        private string GetResourceFileContentAsString(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "QuickStop.Infrastructure.Data." + fileName;

            string resource = null;
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using(StreamReader reader = new StreamReader(stream))
            {
                resource = reader.ReadToEnd();
            }

            return resource;
        }
    }
}
