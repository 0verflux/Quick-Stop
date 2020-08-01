using QuickStop.Components.Exceptions;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System;
using System.IO;

namespace QuickStop.Infrastructure.ModelStreams
{
    /// <summary>
    /// Represents a Reader and Writer for <see cref="HotelBook"/>.
    /// </summary>
    public sealed class HotelBookModelStream : ModelStreamBase, IHotelBookModelStream 
    {

        /// <summary>
        /// Initializes a new Instance of <see cref="HotelBook"/>.
        /// </summary>
        /// <param name="baseDirectory">The base directory of a file.</param>
        public HotelBookModelStream(string baseDirectory) : base(baseDirectory, @"\Data\HotelRoomBookings\", null)
        {

        }

        /// <summary>
        /// Creates a new Booked Hotel Room. 
        /// </summary>
        /// <param name="hotelBook">The data to be stored.</param>
        void IHotelBookModelStream.CreateBookHotel(HotelBook hotelBook)
        {
            string file = FilePath(hotelBook.Reference);

            using(var stream = new FileStream(file, FileMode.Create))
            using(var writer = new StreamWriter(stream))
            {
                writer.WriteLine(hotelBook.HotelID.ToString());
                writer.WriteLine(hotelBook.GuestCount.ToString());
                writer.WriteLine(hotelBook.CheckIn.ToString());
                writer.WriteLine(hotelBook.CheckOut.ToString());
                writer.WriteLine(hotelBook.TotalCost.ToString());
            }
        }

        /// <summary>
        /// Finds all Booked Hotel Room by reference key.
        /// </summary>
        /// <param name="reference">The key to be searched with.</param>
        /// <returns><see cref="HotelBook"/></returns>
        HotelBook IHotelBookModelStream.FindBookHotel(string reference)
        {
            string file = FilePath(reference);

            try
            {
                using(var stream = new FileStream(file, FileMode.Open))
                using(var reader = new StreamReader(stream))
                {
                    HotelBook hotelBook = new HotelBook();

                    hotelBook.Reference = reference;
                    hotelBook.HotelID = Convert.ToInt32(reader.ReadLine());
                    hotelBook.GuestCount = Convert.ToInt32(reader.ReadLine());
                    hotelBook.CheckIn = Convert.ToDateTime(reader.ReadLine());
                    hotelBook.CheckOut = Convert.ToDateTime(reader.ReadLine());
                    hotelBook.TotalCost = Convert.ToDecimal(reader.ReadLine());

                    return hotelBook;
                }
            }
            catch(FileNotFoundException)
            {
                throw new HotelBookReferenceNotFoundException();
            }
        }
    }
}
