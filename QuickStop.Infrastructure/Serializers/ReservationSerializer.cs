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
        public ReservationSerializer(string baseDirectory) : base(baseDirectory, null)
        {

        }

        void IReservationSerializer.CreateReservation(Reservation reservation)
        {
            StringBuilder sb = new StringBuilder();
            string file = Path.Combine(baseDirectory, reservation.Reference + extension);

            sb.AppendLine(reservation.Hotel.ID.ToString());
            sb.AppendLine(reservation.CheckIn.ToString());
            sb.AppendLine(reservation.DurationOfStay.ToString());
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
                Hotel = null, // TODO: Find Hotel by ID ; parameters[0]
                CheckIn = Convert.ToDateTime(parameters[1]),
                DurationOfStay = Convert.ToUInt16(parameters[2]),
                TotalCost = Convert.ToDecimal(parameters[3])
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
