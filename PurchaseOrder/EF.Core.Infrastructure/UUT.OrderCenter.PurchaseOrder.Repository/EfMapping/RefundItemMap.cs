using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class RefundItemMap
    {
        public static void SetConfig(EntityTypeBuilder<RefundItem> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_RefundItem");
            entityBuilder.HasKey(p => p.Id);

            entityBuilder.HasOne(i => i.OrderItem).WithMany().HasForeignKey("OrderItem_Id");

            entityBuilder.HasOne(i => i.OrderItem);
        }
    }
}
