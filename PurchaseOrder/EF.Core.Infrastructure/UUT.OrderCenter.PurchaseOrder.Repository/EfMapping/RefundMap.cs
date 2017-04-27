using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class RefundMap 
    {
        public static void SetConfig(EntityTypeBuilder<Refund> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_Refund");
            entityBuilder.HasKey(p => p.Id);

            entityBuilder.HasMany(r => r.RefundItems);
            
            entityBuilder.Property(r => r.RefundNumber).IsRequired();

            entityBuilder.Ignore(r => r.RefundState);
            entityBuilder.Ignore(r => r.Tourists);
            entityBuilder.Ignore(r => r.RemovedTourists);
            entityBuilder.Ignore(r => r.RemovedRefundItems);

#if EFCore
            entityBuilder.Property(i => i.UserCreatedId).HasColumnName("UserCreated_Id");
            entityBuilder.Property(i => i.UserCreatedFullName).HasColumnName("UserCreated_FullName");
            entityBuilder.Property(i => i.UserCreatedPhone).HasColumnName("UserCreated_Phone");
            entityBuilder.Property(i => i.UserCreatedAgencyId).HasColumnName("UserCreated_AgencyId");
            entityBuilder.Property(i => i.UserCreatedAgencyName).HasColumnName("UserCreated_AgencyName");

            entityBuilder.Ignore(i => i.UserCreated);
#endif
        }
    }
}
