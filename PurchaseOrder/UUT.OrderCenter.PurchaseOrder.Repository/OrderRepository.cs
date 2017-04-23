using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Infrastructure.Interface;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Repository.Interface;
using UUT.OrderCenter.PurchaseOrder.Infrastructure.ExpressionHelper;

namespace UUT.OrderCenter.PurchaseOrder.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(IDbContext dbCtx) : base(dbCtx)
        {
        }

        public override void Update(Order t)
        {
            Context.Entry(t).Property(p => p.UserCreated).IsModified = false;
            Context.Entry(t).Property(p => p.TimeCreated).IsModified = false;
            Context.Entry(t).Property(p => p.OrderSource).IsModified = false;
            Context.Entry(t).Property(p => p.OrderType).IsModified = false;
            Context.Entry(t).Property(p => p.MallOrderId).IsModified = false;
            foreach (var removedTourist in t.RemovedTourists) // ef attachment won't delete element when remove from collection, so delete here
            {
                Context.Set<Tourist>().Remove(removedTourist);
            }
            foreach (var removedAttachment in t.RemovedAttachments)
            {
                Context.Set<OrderAttachment>().Remove(removedAttachment);
            }
        }

        public override async Task<Order> GetByIdAsync(dynamic id)
        {
            var orderId = (Guid)id;
            var query = Context.Set<Order>().Where(o => o.Id == orderId)
               .Include(o => o.Tourists)
               .Include(o => o.OrderItems.Select(i => i.RequirementItem))
               .Include(o => o.Refunds);
               //.Include(o => o.Refunds.Select(r => r.Tourists))
               //.Include(o => o.Refunds.Select(r => r.RefundItems.Select(i => i.OrderItem)));
            // ↑ above three lines will generate improper sql in mysql :(. So it's the only choice to using lazy load manually
#if DEBUG
            var context4Log = (DbContext)Context;
            if (context4Log != null)
            {
                context4Log.Database.Log = m => System.Diagnostics.Debug.Write(m);
            }
#endif
            var order = await query.FirstAsync();

            // manually using lazy load
            Context.Entry(order).Collection(o => o.Refunds).Query()
                .Include(r => r.Tourists)
                .Include(r => r.RefundItems.Select(i => i.OrderItem))
                .Load();

            return order;
        }

        public async Task<long> GetCountAsync(Expression<Func<Order, bool>> filter)
        {
            return await Context.Set<Order>().LongCountAsync(filter);
        }

        public async Task<IEnumerable<int>> GetYearsAsync()
        {
            return await Context.Set<Order>().Select(o => o.TimeCreated.Year).Distinct().OrderByDescending(i => i).ToListAsync();
        }
    }
}
