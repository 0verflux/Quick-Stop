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
            var file = Path.Combine(baseDirectory, reservation.Reference + extension);
            var sb = new StringBuilder();

            // TODO: replace sb with a singleton instance

            sb.Clear();
            sb.AppendLine(reservation.Hotel.ID.ToString());
            sb.AppendLine(reservation.CheckIn.ToString());
            sb.AppendLine(reservation.DurationOfStay.ToString());
            sb.AppendLine(reservation.TotalCost.ToString());

            File.WriteAllText(file, sb.ToString());
        }

        Reservation IReservationSerializer.ReadReservation(string reference)
        {
            var file = Path.Combine(baseDirectory, reference + extension);
            var reservation = new Reservation();

            var parameters = File.ReadAllText(file).Split(delimiters);

            reservation.Reference = reference;
            reservation.Hotel = null; // TODO: Find Hotel by ID ; parameters[0]
            reservation.CheckIn = Convert.ToDateTime(parameters[1]);
            reservation.DurationOfStay = Convert.ToUInt16(parameters[2]);
            reservation.TotalCost = Convert.ToDecimal(parameters[3]);
            
            return reservation;
        }

        bool IReservationSerializer.ReservationExists(string reference)
        {
            var file = Path.Combine(baseDirectory, reference + extension);

            return File.Exists(file);
        }
    }
}
