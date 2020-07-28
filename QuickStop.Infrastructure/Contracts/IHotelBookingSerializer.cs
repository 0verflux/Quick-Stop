using QuickStop.Domain.Models;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IHotelBookSerializer : ISerializer
    {
        void CreateBookHotel(HotelBook reservation);
        HotelBook FindBookHotel(string reference);
        bool BookHotelExists(string reference);
    }
}
