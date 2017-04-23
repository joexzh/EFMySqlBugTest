using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Infrastructure.Interface;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Repository
{
    public class OrderContext : DbContext, IDbContext
    {
        public OrderContext() : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OperationLog> OperationLogs { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<RefundItem> RefundItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !String.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null
                    && type.BaseType.IsGenericType
                    && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            modelBuilder.ComplexType<OrderMoney>().Property(m => m.BaseCurrencyCode).IsRequired();
            modelBuilder.ComplexType<OrderMoney>().Property(m => m.DealCurrencyCode).IsRequired();
            modelBuilder.ComplexType<OrderMoney>().Ignore(p => p.AmountForBaseCurrency);

            modelBuilder.ComplexType<Seller>().Property(s => s.SellerName);
            modelBuilder.ComplexType<User>();
            modelBuilder.ComplexType<SettlementItemComplexType>().Property(s => s.SerializedValue).HasColumnName("SettlementItems");
            modelBuilder.ComplexType<UseDatesComplexType>().Property(d => d.SerializedValue).HasColumnName("UseDates");

            Database.SetInitializer<OrderContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
