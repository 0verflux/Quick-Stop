using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System;
using System.IO;
using System.Text;

namespace QuickStop.Infrastructure.Serializers
{
    public sealed class ReservationSerializer : SerializerBase, IHotelBookSerializer
    {
        public ReservationSerializer(string baseDirectory) : base(baseDirectory, null)
        {

        }

        void IHotelBookSerializer.CreateBookHotel(HotelBook reservation)
        {
            StringBuilder sb = new StringBuilder();
            string file = Path.Combine(baseDirectory, reservation.Reference + extension);

            sb.AppendLine(reservation.HotelID.ToString());
            sb.AppendLine(reservation.GuestCount.ToString());
            sb.AppendLine(reservation.CheckIn.ToString());
            sb.AppendLine(reservation.CheckOut.ToString());
            sb.Append(reservation.TotalCost.ToString());

            File.WriteAllText(file, sb.ToString());
        }

        HotelBook IHotelBookSerializer.FindBookHotel(string reference)
        {
            try
            {
                string file = Path.Combine(baseDirectory, reference + extension);
                string[] parameters = File.ReadAllLines(file);

                HotelBook reservation = new HotelBook
                {
                    Reference = reference,
                    HotelID = Convert.ToInt32(parameters[0]),
                    GuestCount = Convert.ToInt32(parameters[1]),
                    CheckIn = Convert.ToDateTime(parameters[2]),
                    CheckOut = Convert.ToDateTime(parameters[3]),
                    TotalCost = Convert.ToDecimal(parameters[4])
                };

                return reservation;
            }
            catch(Exception ex)
            {
                throw ex; // TODO: Throw BookingNotFoundException
            }
        }

        bool IHotelBookSerializer.BookHotelExists(string reference)
        {
            string file = Path.Combine(baseDirectory, reference + extension);

            return File.Exists(file);
        }
    }
}
