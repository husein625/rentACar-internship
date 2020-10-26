using Praksa.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace praksa_rent.Domain
{
    public class Contact : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime DeateCreated { get; set; }
        public string Question { get; set; }

    }
}
