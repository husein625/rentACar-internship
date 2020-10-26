using Praksa.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace praksa_rent.Domain
{
    public class Review : BaseEntity
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }

    }
}
