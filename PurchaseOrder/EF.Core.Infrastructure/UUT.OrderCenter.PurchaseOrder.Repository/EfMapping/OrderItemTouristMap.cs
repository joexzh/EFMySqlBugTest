using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.RelationTable;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class OrderItemTouristMap
    {
        public static void SetConfig(EntityTypeBuilder<OrderItemTourist> entityBuilder)
        {
            entityBuilder.ToTable("purchase_orderitem_tourist");

            entityBuilder.HasKey(r => new { r.OrderItemId, r.TouristId });

#if EFCore
            entityBuilder.HasOne(r => r.Tourist).WithMany().HasForeignKey(r => r.TouristId);

            entityBuilder.HasOne(r => r.OrderItem).WithMany(o => o.OrderItemTourists).HasForeignKey(r => r.OrderItemId);
#endif
        }
    }
}
