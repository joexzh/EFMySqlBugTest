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
    public class OrderItemMap : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMap()
        {
            ToTable("Purchase_OrderItem");
            Ignore(p => p.TotalPrice);
            
            HasKey(p => p.Id);
            Property(p => p.ProductType).IsRequired();
            Property(p => p.ProductName).IsRequired();
            Property(p => p.ItemName).IsRequired();
            Property(p => p.CurrencyCode).IsRequired();

            HasMany(i => i.Tourists).WithMany()
                .Map(m =>
                {
                    m.ToTable("Purchase_OrderItem_Tourist");
                    m.MapLeftKey("OrderItemId");
                    m.MapRightKey("TouristId");
                });

            HasRequired(i => i.Order);

            HasOptional(i => i.RequirementItem);
        }
    }
}
