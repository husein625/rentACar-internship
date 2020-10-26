using Microsoft.EntityFrameworkCore;
using Praksa.DAL;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.Repositories.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly RentDbContext _context;
        public UserRepository(RentDbContext context)
        {
            _context = context;
        }
        public async Task<UserViewModel> GetTopTen()
        {
            const int maxTop = 10;
            var collection = await _context.Users.ToListAsync();
            return new UserViewModel(collection);
        }

        int IUserRepository.GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
