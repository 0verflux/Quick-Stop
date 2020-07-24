using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace QuickStop.Infrastructure
{
    public class ReservationDataAccess : DataAccessBase<Reservation>, IReservationDataAccess
    {
        public ReservationDataAccess() : base()
        {

        }

        void IReservationDataAccess.CreateReservation(Reservation reservation)
        {
            collection.Add(reservation);
        }

        Reservation IDataAccess<Reservation>.GetByID(int id)
        {
            return collection.Where(x => x.ID == id).First();
        }

        IEnumerable<Reservation> IDataAccess<Reservation>.GetCollection()
        {
            return collection;
        }
    }
}
