using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable("Purchase_Order");
            //Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(p => p.Id);
            HasMany(o => o.OperationLogs);
            HasMany(o => o.OrderItems);
            Ignore(p => p.OrderState);
            Ignore(p => p.RemovedTourists);
            Ignore(p => p.ProductName);

            Property(p => p.OrderNumber).IsRequired();
        }
    }
}
