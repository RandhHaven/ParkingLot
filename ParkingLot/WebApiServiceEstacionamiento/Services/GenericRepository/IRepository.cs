namespace WebApiServiceEstacionamiento.Services.GenericRepository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : class
    {
        Task<T> Get(Int64 id);

        Task<IEnumerable<T>> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            String includeProperties = null);

        Task<T> GetFirstOrDefault(
            Expression<Func<T, bool>> filter,
            String includeProperties = null);

        void Add(T entity);

        void Remove(Int64 id);

        void Remove(T entity);

    }
}
