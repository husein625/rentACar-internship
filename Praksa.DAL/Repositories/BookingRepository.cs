using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.Repositories.Repositories
{
    class BookingRepository : BaseRepository<Booking>, IBookingRepository
    {
        public List<Booking> GetAllForUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetInPeriod(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
