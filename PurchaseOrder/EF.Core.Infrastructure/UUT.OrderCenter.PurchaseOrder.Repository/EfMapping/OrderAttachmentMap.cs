using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class OrderAttachmentMap
    {
        public OrderAttachmentMap(EntityTypeBuilder<OrderAttachment> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_Attachment");
            //Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            entityBuilder.Property(p => p.DownloadUrl).IsRequired();
            entityBuilder.HasKey(p => p.Id);
        }
    }
}
