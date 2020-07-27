﻿using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickStop.Infrastructure.Contracts
{
    public interface IHotelRepository
    {
        IEnumerable<HotelRoom> GetHotels(Location location, int guestCount, Sort sort);

        void Save();
        HotelRoom FindHotelByID(int id);
        void SetHotelInavailablity(int id, DateTime dateTime);
    }
}
