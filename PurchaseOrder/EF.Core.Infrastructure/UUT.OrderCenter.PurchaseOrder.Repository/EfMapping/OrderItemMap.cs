using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class OrderItemMap
    {
        public OrderItemMap(EntityTypeBuilder<OrderItem> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_OrderItem");
            entityBuilder.Ignore(p => p.TotalPrice);

            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(p => p.ProductType).IsRequired();
            entityBuilder.Property(p => p.ProductName).IsRequired();
            entityBuilder.Property(p => p.ItemName).IsRequired();
            entityBuilder.Property(p => p.CurrencyCode).IsRequired();
            
            // todo the mapping
            //entityBuilder.HasMany(i => i.Tourists).WithMany()
            //    .Map(m =>
            //    {
            //        m.ToTable("Purchase_OrderItem_Tourist");
            //        m.MapLeftKey("OrderItemId");
            //        m.MapRightKey("TouristId");
            //    });

            //entityBuilder.HasRequired(i => i.Order);

            //entityBuilder.HasOptional(i => i.RequirementItem);
        }
    }
}
