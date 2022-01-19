using System;
using System.Linq;
using System.Linq.Expressions;
using University.Contract;
using UniversityDb;

namespace Repository
{
        public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
        {
            protected UniversityDbContext Context { get; set; }
            public RepositoryBase(UniversityDbContext Context)
            {
                this.Context = Context;
            }
            public IQueryable<T> FindAll()
            {
            return Context.Set<T>(); //.AsNoTracking();  check it after all
            }
            public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
            {
            return Context.Set<T>().Where(expression); //.AsNoTracking(); check it after all 
            }
            public void Create(T entity)
            {
                Context.Set<T>().Add(entity);
            }
            public void Update(T entity)
            {
                Context.Set<T>().Update(entity);
            }
            public void Delete(T entity)
            {
                Context.Set<T>().Remove(entity);
            }
    }
}
