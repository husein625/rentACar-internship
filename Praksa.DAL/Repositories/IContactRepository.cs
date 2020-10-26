using Praksa.DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Praksa.DAL.Repositories
{
   public interface IContactRepository
    {
        Task<ContactViewModel> GetContacts();
    }
}
