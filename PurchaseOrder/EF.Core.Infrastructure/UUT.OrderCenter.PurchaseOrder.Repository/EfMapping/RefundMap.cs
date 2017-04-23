using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class RefundMap 
    {
        public RefundMap(EntityTypeBuilder<Refund> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_Refund");
            entityBuilder.HasKey(p => p.Id);

            // todo new mapping
            //entityBuilder.HasMany(r => r.Tourists).WithMany()
            //    .Map(m =>
            //    {
            //        m.ToTable("Purchase_Refund_Tourist");
            //        m.MapLeftKey("RefundId");
            //        m.MapRightKey("TouristId");
            //    });
            entityBuilder.HasMany(r => r.RefundItems);

            // todo new mapping
            //entityBuilder.HasRequired(r => r.Order);

            entityBuilder.Property(r => r.RefundNumber).IsRequired();

            entityBuilder.Ignore(r => r.RefundState);
        }
    }
}
