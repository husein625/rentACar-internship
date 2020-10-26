using Microsoft.EntityFrameworkCore;
using Praksa.DAL.ViewModel;
using praksa_rent.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.DAL.Repositories
{
   public class ContactRepository : IContactRepository
    {
        private readonly RentDbContext _rentDbContext;
        public ContactRepository(RentDbContext rentDbContext)
        {
            _rentDbContext = rentDbContext;
        }
       


        public async Task<ContactViewModel> GetContacts()
        {
            var collection = await _rentDbContext.Contacts.ToListAsync();
            return new ContactViewModel(collection);
        }

      

 
    }
}
