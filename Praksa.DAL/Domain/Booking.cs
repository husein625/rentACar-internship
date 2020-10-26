using Praksa.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace praksa_rent.Domain
{
    public class Booking : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public float TotalPrice { get; set; }

    }
}
