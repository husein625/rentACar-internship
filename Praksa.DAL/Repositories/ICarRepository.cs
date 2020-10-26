using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.Repositories.Repositories
{
    interface ICarRepository
    {
        List<Car> GetPopular();
    }
}
