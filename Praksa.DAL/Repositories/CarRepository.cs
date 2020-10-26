using Microsoft.EntityFrameworkCore;
using Praksa.DAL;
using Praksa.DAL.ViewModel;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Praksa.Repositories.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly RentDbContext _context;
        public CarRepository(RentDbContext context)
        {
            _context = context;
        }

        public async Task EditCar(int carId, CarDto car, CancellationToken cancellationToken = default)
        {
            var carDomain = await _context.Cars.FindAsync(carId);
            carDomain.Name = car.CarName;
            carDomain.Year = car.YearOFProduction;
            carDomain.HorsePower = car.HorsePower;
            carDomain.NumberOfDoors = car.NumberOfDoors;
            carDomain.Price = car.Price;
            carDomain.ImageUrl = car.ImageURL;
            carDomain.ColorId = car.ColorID;
            _context.Cars.Update(carDomain);
            await _context.SaveChangesAsync();

        }

        public async Task<CarViewModel> GetCars(CancellationToken cancellationToken = default)
        {
            var collection = await _context.Cars.ToListAsync(cancellationToken);
            return new CarViewModel(collection);
        }

        public async Task<int> SaveCar(CarDto car, CancellationToken cancellationToken = default)
        {
            var carDomain = new Car
            {
                Name = car.CarName,
                Year = car.YearOFProduction,
                HorsePower = car.HorsePower,
                NumberOfDoors = car.NumberOfDoors,
                Price = car.Price,
                ImageUrl = car.ImageURL,
                ColorId = car.ColorID
            };
            await _context.Cars.AddAsync(carDomain, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return carDomain.Id;

        }
    }
}