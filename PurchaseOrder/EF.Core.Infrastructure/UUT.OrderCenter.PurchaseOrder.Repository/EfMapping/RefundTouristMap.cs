using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.RelationTable;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class RefundTouristMap
    {
        public static void SetConfig(EntityTypeBuilder<RefundTourist> entityBuilder)
        {
            entityBuilder.ToTable("purchase_refund_tourist");

            entityBuilder.HasKey(r => new { r.RefundId, r.TouristId });

#if EFCore
            entityBuilder.HasOne(r => r.Tourist).WithMany().HasForeignKey(r => r.TouristId);
            entityBuilder.HasOne<Refund>().WithMany(r => r.RefundTourists).HasForeignKey(r => r.RefundId);
#endif
        }
    }
}
