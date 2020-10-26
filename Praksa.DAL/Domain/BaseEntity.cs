using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
