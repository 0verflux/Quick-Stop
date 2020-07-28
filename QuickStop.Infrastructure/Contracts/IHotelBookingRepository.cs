using QuickStop.Domain.Models;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IHotelBookingRepository
    {
        void BookHotel(HotelBook reservation);
        HotelBook FindBookHotel(string reference);
        bool BookHotelExists(string reference);
    }
}
