using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Shared;

namespace UUT.OrderCenter.PurchaseOrder.Repository.Interface
{
    public interface IRepository<T> where T : AggregateRoot
    {
        /// <summary>
        /// Item1: list, Item2: TotalCount
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        Task<Tuple<IEnumerable<T>, long>> GetAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int pageIndex = 0,
            int pageSize = 0,
            string includeProperties = "");
        
        Task<T> GetByIdAsync(dynamic id);

        void Add(T t);

        void Update(T t);

        void Delete(T t);
    }
}
