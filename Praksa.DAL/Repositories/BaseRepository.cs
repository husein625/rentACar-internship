using Praksa.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.Repositories.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public T Add(T obj)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T obj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
