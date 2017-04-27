using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class OperationLogMap
    {
        public static void SetConfig(EntityTypeBuilder<OperationLog> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_OperationLog");
            entityBuilder.HasKey(p => p.Id);

            entityBuilder.Ignore(o => o.OperatedUser);

#if EFCore
            entityBuilder.Property(o => o.OperatedUserId).HasColumnName("OperatedUser_Id");
            entityBuilder.Property(o => o.OperatedUserFullName).HasColumnName("OperatedUser_FullName");
            entityBuilder.Property(o => o.OperatedUserPhone).HasColumnName("OperatedUser_Phone");
            entityBuilder.Property(o => o.OperatedUserAgencyId).HasColumnName("OperatedUser_AgencyId");
            entityBuilder.Property(o => o.OperatedUserAgencyName).HasColumnName("OperatedUser_AgencyName");
#endif
        }
    }
}
