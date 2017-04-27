using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class RequirementMap
    {
        public static void SetConfig(EntityTypeBuilder<Requirement> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Requirement");
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.HasMany(r => r.RequirementItems).WithOne(r => r.Requirement).HasForeignKey("Requirement_Id");
            entityBuilder.Property(r => r.RequirementNumber).IsRequired();
            entityBuilder.Property(r => r.ResName).IsRequired();

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
