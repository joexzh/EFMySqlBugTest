using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class OrderAttachmentMap
    {
        public static void SetConfig(EntityTypeBuilder<OrderAttachment> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_Attachment");
            entityBuilder.Property(p => p.DownloadUrl).IsRequired();
            entityBuilder.HasKey(p => p.Id);
        }
    }
}
