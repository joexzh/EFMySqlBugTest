using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class RefundMap : EntityTypeConfiguration<Refund>
    {
        public RefundMap()
        {
            ToTable("Purchase_Order_Refund");
            //Property(r => r.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            HasKey(p => p.Id);
            HasMany(r => r.Tourists).WithMany()
                .Map(m =>
                {
                    m.ToTable("Purchase_Refund_Tourist");
                    m.MapLeftKey("RefundId");
                    m.MapRightKey("TouristId");
                });
            HasMany(r => r.RefundItems);

            HasRequired(r => r.Order);

            Property(r => r.RefundNumber).IsRequired();

            Ignore(r => r.RefundState);
        }
    }
}
