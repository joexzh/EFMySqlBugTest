using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.RepositoryCore;
using UUT.OrderCenter.PurchaseOrder.RepositoryCore.Tools;

namespace Mysql.Pomelo.EFCore.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task ef_core_test()
        {
            var ctx = new OrderContext();

            var serviceProvider = ctx.GetInfrastructure<IServiceProvider>();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddProvider(new MyLoggerProvider());

            var orderRepo = new OrderRepository(ctx);
            var orderIds = await ctx.Orders.Select(o => o.Id).ToListAsync();

            var orders = new List<Order>();
            foreach (var orderId in orderIds)
            {
                var order = await orderRepo.GetByIdAsync(orderId);
                orders.Add(order);
            }

            Assert.IsTrue(orders.Count > 0);
        }
    }
}
