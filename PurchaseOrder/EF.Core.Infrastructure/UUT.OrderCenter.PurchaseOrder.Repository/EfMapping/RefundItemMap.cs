using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class RefundItemMap
    {
        public RefundItemMap(EntityTypeBuilder<RefundItem> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_RefundItem");
            entityBuilder.HasKey(p => p.Id);
            // todo new mapping
            //entityBuilder.HasRequired(i => i.OrderItem);
        }
    }
}
