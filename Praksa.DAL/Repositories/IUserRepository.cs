using Praksa.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Repositories.Repositories
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetTopTen();
        int GetById(int Id);
    }
}
