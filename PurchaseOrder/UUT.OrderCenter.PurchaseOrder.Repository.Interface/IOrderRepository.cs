using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Repository.Interface
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<long> GetCountAsync(Expression<Func<Order, bool>> filter);

        /// <summary>
        /// Get years of all orders
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<int>> GetYearsAsync();
    }
}
