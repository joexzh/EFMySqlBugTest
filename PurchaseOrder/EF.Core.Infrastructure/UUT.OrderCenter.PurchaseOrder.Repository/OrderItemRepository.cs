using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.InfrastructureCore.InterfaceCore;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace UUT.OrderCenter.PurchaseOrder.Repository
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(IDbContext dbCtx) : base(dbCtx)
        {
        }

        public override void Update(OrderItem t)
        {
            Context.Entry(t).Property(p => p.UserCreated).IsModified = false;
            Context.Entry(t).Property(p => p.TimeCreated).IsModified = false;
            //Context.Entry(t).Property(p => p.RequirementItem).IsModified = false;
        }

        public async override Task<OrderItem> GetByIdAsync(dynamic id)
        {
            var orderItemId = (Guid)id;
            return await Context.Set<OrderItem>().Where(i => i.Id == orderItemId).Include(i => i.Tourists).FirstAsync();
        }
    }
}
