using System;
using System.Linq;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.InfrastructureCore.InterfaceCore;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore
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
        }
        
    }
}
