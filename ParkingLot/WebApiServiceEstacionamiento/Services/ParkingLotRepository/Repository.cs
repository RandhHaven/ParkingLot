namespace WebApiServiceEstacionamiento.Services.ParkingLotRepository
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using WebApiServiceEstacionamiento.ParkingLotModel;

    public class Repository<T> : IRepository<T> where T : class
    {
        #region Properties
        private readonly DatabaseContext _databaseContext;
        internal DbSet<T> _dbSet;
        #endregion

        #region Build
        public Repository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext
                ?? throw new ArgumentNullException(nameof(databaseContext));
            this._dbSet = databaseContext.Set<T>();
        }
        #endregion

        public void Add(T entity)
        {
            this._dbSet.Add(entity);
        }

        public async Task<T> Get(Int64 id)
        {
            var objectFind = this._dbSet.Find(id);
            return await Task.Factory.StartNew(() => objectFind);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = this._dbSet;
            if (!Object.Equals(filter, null))
            {
                query = query.Where(filter);
            }
            if (!Object.Equals(includeProperties, null))
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            if (!Object.Equals(orderBy, null))
            {
                return await orderBy(query).ToListAsync();
            }
            return await query.ToListAsync();
        }

        public Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {           
        }

        public void Remove(T entity)
        {
            this._dbSet.Remove(entity);
        }
    }
}
