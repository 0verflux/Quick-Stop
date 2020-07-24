using QuickStop.Domain.Models;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IHotelDataAccess : IDataAccess<Hotel>
    {
        void ChangeHotelAvailability(int id);
    }
}
