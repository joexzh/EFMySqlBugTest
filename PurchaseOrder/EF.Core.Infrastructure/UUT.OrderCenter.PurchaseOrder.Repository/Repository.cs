using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.InfrastructureCore.InterfaceCore;
using UUT.OrderCenter.PurchaseOrder.Domain.Shared;
using UUT.OrderCenter.PurchaseOrder.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore
{
    public abstract class Repository<T> : IRepository<T> where T : AggregateRoot
    {
        private readonly IDbContext _dbCtx;

        protected Repository(IDbContext dbCtx)
        {
            _dbCtx = dbCtx;
        }

        protected IDbContext Context => _dbCtx;

        public virtual async Task<Tuple<IEnumerable<T>, long>> GetAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int pageIndex = 0,
            int pageSize = 0,
            string includeProperties = "")
        {
            IQueryable<T> query = _dbCtx.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
                if (pageIndex != 0 && pageSize != 0)
                {
                    query = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize);
                }
            }

#if DEBUG
            // todo log
            //var context4Log = (DbContext)Context;
            //if (context4Log != null)
            //{
            //    ((DbContext)Context).Database.Log = m => System.Diagnostics.Debug.Write(m);
            //}
#endif
            var list = await query.ToListAsync();
            var totalCount = await _dbCtx.Set<T>().LongCountAsync(filter);
            return Tuple.Create<IEnumerable<T>, long>(list, totalCount);
        }

        public virtual async Task<T> GetByIdAsync(dynamic id)
        {
            var guid = (Guid)id;
            return await _dbCtx.Set<T>().SingleOrDefaultAsync(i => i.Id == guid);
        }

        public virtual void Add(T t)
        {
            _dbCtx.Set<T>().Add(t);
        }

        public virtual void Update(T t)
        {
            _dbCtx.Entry(t).State = EntityState.Modified;
        }

        public virtual void Delete(T t)
        {
            _dbCtx.Set<T>().Remove(t);
        }
    }
}
