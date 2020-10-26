using Praksa.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace praksa_rent.Domain
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int ColorId { get; set; }
        public Color Color{ get; set; }
        public int HorsePower { get; set; }
        public int NumberOfDoors { get; set; }
        public float Price { get; set; }
        public string ImageUrl { get; set; }

    }

}
