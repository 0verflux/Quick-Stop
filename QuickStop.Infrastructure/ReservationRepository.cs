using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace QuickStop.Infrastructure
{
    public class ReservationRepository : RepositoryBase<Reservation>, IReservationRepository
    {
        public ReservationRepository(string baseDirectory) : base(baseDirectory)
        {

        }

        void IReservationRepository.CreateReservation(Reservation reservation)
        {
            // TODO: Create a reservation file
        }

        Reservation IReservationRepository.GetReservation(string reference)
        {
            // TODO: Find a reservation file
            return default;
        }

        bool IReservationRepository.ReservationExists(string reference)
        {
            // TODO: Check if reservation file exists
            return true;
        }
    }
}
