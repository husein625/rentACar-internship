using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.Repositories.Repositories
{
    class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public List<Car> GetPopular()
        {
            throw new NotImplementedException();
        }
    }
}
