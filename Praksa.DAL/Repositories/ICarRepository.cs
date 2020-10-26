using Praksa.DAL.ViewModel;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Praksa.Repositories.Repositories
{
    public interface ICarRepository
    {
        Task<CarViewModel> GetCars(CancellationToken cancellationToken = default);
        Task<int> SaveCar(CarDto car, CancellationToken cancellationToken = default);
        Task EditCar(int carId, CarDto car, CancellationToken cancellationToken = default);
    }
}