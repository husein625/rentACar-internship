using Praksa.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace praksa_rent.Domain
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public List<UserRoles> UserRoles { get; set; }

    }
}
