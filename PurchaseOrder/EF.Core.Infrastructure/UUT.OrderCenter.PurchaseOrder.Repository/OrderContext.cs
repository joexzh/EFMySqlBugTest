using UUT.OrderCenter.PurchaseOrder.InfrastructureCore.InterfaceCore;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping;
using UUT.OrderCenter.PurchaseOrder.Domain.RelationTable;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using UUT.OrderCenter.PurchaseOrder.RepositoryCore.Tools;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore
{
    public class OrderContext : DbContext, IDbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<OperationLog> OperationLogs { get; set; }

        public DbSet<Tourist> Tourists { get; set; }

        public DbSet<Refund> Refunds { get; set; }

        public DbSet<RefundItem> RefundItems { get; set; }

        public DbSet<OrderItemTourist> OrderItemTourists { get; set; }

        public DbSet<RefundTourist> RefundTourists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OperationLogMap.SetConfig(modelBuilder.Entity<OperationLog>());
            OrderAttachmentMap.SetConfig(modelBuilder.Entity<OrderAttachment>());
            OrderItemMap.SetConfig(modelBuilder.Entity<OrderItem>());
            OrderItemTouristMap.SetConfig(modelBuilder.Entity<OrderItemTourist>());
            OrderMap.SetConfig(modelBuilder.Entity<Order>());
            RefundItemMap.SetConfig(modelBuilder.Entity<RefundItem>());
            RefundMap.SetConfig(modelBuilder.Entity<Refund>());
            RefundTouristMap.SetConfig(modelBuilder.Entity<RefundTourist>());
            RequirementItemMap.SetConfig(modelBuilder.Entity<RequirementItem>());
            RequirementMap.SetConfig(modelBuilder.Entity<Requirement>());
            TouristMap.SetConfig(modelBuilder.Entity<Tourist>());
            
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
