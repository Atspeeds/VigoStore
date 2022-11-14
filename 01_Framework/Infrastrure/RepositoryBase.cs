using _01_Framework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _01_Framework.Infrastrure
{
    public class RepositoryBase<TKey, T> : IRepository<TKey, T> where T : class
    {
        private readonly DbContext Context;

        public RepositoryBase(DbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Any(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public T GetById(long id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            Context.Update(entity);
        }
    }
}
