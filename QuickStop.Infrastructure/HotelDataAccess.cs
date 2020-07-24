using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Base;
using QuickStop.Infrastructure.Contracts;
using System.Collections.Generic;
using System.Linq;
namespace QuickStop.Infrastructure
{
    public sealed class HotelDataAccess : DataAccessBase<Hotel>, IHotelDataAccess
    {
        public HotelDataAccess() : base()
        {

        }

        void IHotelDataAccess.ChangeHotelAvailability(int id)
        {
            // TODO: Implement method that changes hotel availability on call, kind of like a flip switch
        }

        IEnumerable<Hotel> IDataAccess<Hotel>.GetCollection()
        {
            return collection;
        }

        Hotel IDataAccess<Hotel>.GetByID(int id)
        {
            return collection.Where(x => x.ID == id).First();
        }
    }
}
