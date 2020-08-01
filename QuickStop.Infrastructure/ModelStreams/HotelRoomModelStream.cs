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

namespace QuickStop.Infrastructure.ModelStreams
{
    /// <summary>
    /// Represents a Reader and Writer for <see cref="HotelRoom"/>.
    /// </summary>
    public sealed class HotelRoomModelStream : ModelStreamBase, IHotelRoomModelStream 
    {
        private readonly string fileName;

        /// <summary>
        /// Initializes a new Instance of <see cref="HotelRoomModelStream"/>.
        /// </summary>
        /// <param name="baseDirectory">The base directory of the file.</param>
        public HotelRoomModelStream(string baseDirectory) : base(baseDirectory, @"\Data\", ',')
        {
            fileName = "HotelData";
        }

        IEnumerable<HotelRoom> IHotelRoomModelStream.ReadAllHotels()
        {
            List<HotelRoom> hotels = new List<HotelRoom>();
            string file = FilePath(fileName);
            string data = null;

            // Check if File Exists
            // If no file is found, a new file is made.
            if (!File.Exists(file))
            {
                string src = GetResourceFileContent(fileName + extension);
                File.WriteAllText(file, src);
            }

            // start a stream reader
            using (var stream = new FileStream(file, FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                // read all data each line until it reaches the end of line
                while ((data = reader.ReadLine()) != null)
                {
                    // splits all data by a delimiter
                    string[] hotelParams = parser.Split(data);

                    try
                    {
                        HotelRoom hotel = new HotelRoom();

                        hotel.ID = Convert.ToInt32(hotelParams[0]);
                        hotel.Name = hotelParams[1].Trim('\"');
                        hotel.Description = hotelParams[2].Trim('\"');
                        hotel.Price = Convert.ToDecimal(hotelParams[3]);
                        hotel.Ratings = Convert.ToUInt16(hotelParams[4]);
                        hotel.Location = (Location)Enum.Parse(typeof(Location), hotelParams[5]);
                        hotel.MinGuestCount = Convert.ToInt32(hotelParams[6]);
                        hotel.MaxGuestCount = Convert.ToInt32(hotelParams[7]);
                        hotel.DateUntilAvailable = string.IsNullOrWhiteSpace(hotelParams[8]) ? null : (DateTime?)Convert.ToDateTime(hotelParams[8]);
                        hotel.Icon = hotelParams[9];
                        hotel.Room = hotelParams[10];

                        hotels.Add(hotel);
                    }
                    catch { }
                }
            }

            return hotels;
        }

        void IHotelRoomModelStream.WriteAllHotels(IEnumerable<HotelRoom> hotels)
        {
            StringBuilder sb = new StringBuilder();
            string file = FilePath(fileName);

            using (var stream = new FileStream(file, FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                foreach(HotelRoom hotel in hotels)
                {
                    sb.Clear();

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

                    writer.WriteLine(sb.ToString());
                }
            }
        }

        /// <summary>
        /// Inserts a delimiter.
        /// </summary>
        /// <param name="str">The string to be added with a delimiter.</param>
        /// <param name="ignoreDelimiterOnString">ignore delimiters inside of the string.</param>
        /// <returns></returns>
        private string IncludeDelimiter(string str, bool ignoreDelimiterOnString = false)
        {
            string quote = ignoreDelimiterOnString ? "\"" : null;
            return $"{quote}{str}{quote}{delimiters.First()}";
        }

        /// <summary>
        /// Gets all content inside of a file.
        /// </summary>
        /// <param name="fileName">The filename to be opened.</param>
        /// <returns></returns>
        private string GetResourceFileContent(string fileName)
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
