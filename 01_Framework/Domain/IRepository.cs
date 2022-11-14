using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _01_Framework.Domain
{
    public interface IRepository<Tkey,T>
    {
        T GetById(long id);
        void Add(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        bool Exists(Expression<Func<T, bool>> predicate);
        void Save();

    }
}
