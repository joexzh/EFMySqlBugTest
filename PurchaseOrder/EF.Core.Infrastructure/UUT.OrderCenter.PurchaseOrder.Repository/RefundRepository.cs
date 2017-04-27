using System;
using System.Linq;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.InfrastructureCore.InterfaceCore;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore
{
    public class RefundRepository : Repository<Refund>, IRefundRepository
    {
        public RefundRepository(IDbContext dbCtx) : base(dbCtx)
        {
            
        }

        public override void Update(Refund t)
        {
            Context.Entry(t).Property(r => r.UserCreated).IsModified = false;
            Context.Entry(t).Property(r => r.TimeCreated).IsModified = false;
            foreach (var item in t.RemovedRefundItems)
            {
                Context.Set<RefundItem>().Remove(item);
            }
        }

        public override async Task<Refund> GetByIdAsync(dynamic id)
        {
            var refundId = (Guid)id;
            return await Context.Set<Refund>().Where(r => r.Id == refundId)
                .Include(r => r.Tourists)
                .Include(r => r.RefundItems.Select(i => i.OrderItem))
                .Include(r => r.Order)
                .FirstAsync();
        }
    }
}
