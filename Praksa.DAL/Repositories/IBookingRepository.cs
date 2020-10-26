using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.Repositories.Repositories
{
    interface IBookingRepository
    {
        List<Booking> GetInPeriod(DateTime from, DateTime to);
        List<Booking> GetAllForUser(int id);
    }
}
