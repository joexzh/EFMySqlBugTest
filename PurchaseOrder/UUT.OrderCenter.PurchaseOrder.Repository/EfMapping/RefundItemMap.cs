using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class RefundItemMap : EntityTypeConfiguration<RefundItem>
    {
        public RefundItemMap()
        {
            ToTable("Purchase_Order_RefundItem");
            //Property(r => r.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            HasKey(p => p.Id);
            HasRequired(i => i.OrderItem);
        }
    }
}
