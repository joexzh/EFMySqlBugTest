using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class OrderAttachmentMap : EntityTypeConfiguration<OrderAttachment>
    {
        public OrderAttachmentMap()
        {
            ToTable("Purchase_Order_Attachment");
            //Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.DownloadUrl).IsRequired();
            HasKey(p => p.Id);
        }
    }
}
