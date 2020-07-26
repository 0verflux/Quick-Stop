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
    public sealed class ReservationSerializer : SerializerBase, IReservationSerializer
    {
        private readonly IHotelRepository hotelRepository;

        public ReservationSerializer(IHotelRepository hotelRepository, string baseDirectory) : base(baseDirectory, null)
        {
            this.hotelRepository = hotelRepository;
        }

        void IReservationSerializer.CreateReservation(Reservation reservation)
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

        Reservation IReservationSerializer.ReadReservation(string reference)
        {
            string file = Path.Combine(baseDirectory, reference + extension);
            string[] parameters = File.ReadAllLines(file);
            
            Reservation reservation = new Reservation
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

        bool IReservationSerializer.ReservationExists(string reference)
        {
            string file = Path.Combine(baseDirectory, reference + extension);

            return File.Exists(file);
        }
    }
}
