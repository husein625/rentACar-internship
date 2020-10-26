using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.DAL.ViewModel
{
    public class CarDto
    {
        public CarDto()
        {

        }
        public CarDto(Car car)
        {
            Id = car.Id;
            CarName = car.Name;
            YearOFProduction = car.Year;
            HorsePower = car.HorsePower;
            NumberOfDoors = car.NumberOfDoors;
            Price = car.Price;
            ImageURL = car.ImageUrl;
            ColorID = car.ColorId;
        }

        public int Id { get; set; }
        public string CarName { get; set; }
        public int YearOFProduction { get; set; }
        public int HorsePower { get; set; }
        public int NumberOfDoors { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public int ColorID { get; set; }

    }
}