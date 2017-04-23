using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Repository;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1Async()
        {
            var ctx = new OrderContext();
            var orderRepo = new OrderRepository(ctx);
            var orderIds = await ctx.Orders.Select(o => o.Id).ToListAsync();

            var orders = new List<Order>();
            orderIds.ForEach(async (i) =>
            {
                var order = await orderRepo.GetByIdAsync(i);
                orders.Add(order);
            });

            Assert.IsTrue(orders.Count > 0);
        }
    }
}
