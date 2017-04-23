using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.InfrastructureCore.InterfaceCore;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using UUT.OrderCenter.PurchaseOrder.Repository.EfMapping;

namespace UUT.OrderCenter.PurchaseOrder.Repository
{
    public class OrderContext : DbContext, IDbContext
    {
        public OrderContext() : base("DefaultConnection")
        {
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<OperationLog> OperationLog { get; set; }
        public DbSet<Tourist> Tourist { get; set; }
        public DbSet<Refund> Refund { get; set; }
        public DbSet<RefundItem> RefundItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new OperationLogMap(modelBuilder.Entity<OperationLog>());
            // todo mappings
            
            //modelBuilder.ComplexType<OrderMoney>().Property(m => m.BaseCurrencyCode).IsRequired();
            //modelBuilder.ComplexType<OrderMoney>().Property(m => m.DealCurrencyCode).IsRequired();
            //modelBuilder.ComplexType<OrderMoney>().Ignore(p => p.AmountForBaseCurrency);

            //modelBuilder.ComplexType<Seller>().Property(s => s.SellerName);
            //modelBuilder.ComplexType<User>();
            //modelBuilder.ComplexType<SettlementItemComplexType>().Property(s => s.SerializedValue).HasColumnName("SettlementItems");
            //modelBuilder.ComplexType<UseDatesComplexType>().Property(d => d.SerializedValue).HasColumnName("UseDates");

            //Database.SetInitializer<OrderContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
