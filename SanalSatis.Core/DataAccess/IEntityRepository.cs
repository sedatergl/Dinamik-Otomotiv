using SanalSatis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SanalSatis.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);
        T GetByNameAndPassword(Expression<Func<T, bool>> filter = null);
        T GetById(Expression<Func<T, bool>> filter = null);

        void Update(T entity);

        void Delete(T entity);
    }
}
