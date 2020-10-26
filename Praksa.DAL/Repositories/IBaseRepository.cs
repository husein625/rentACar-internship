using Praksa.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.Repositories.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(int id);
        bool Update(TEntity obj, int id);
        List<TEntity> GetAll();
        TEntity Add(TEntity obj);

    }
}
