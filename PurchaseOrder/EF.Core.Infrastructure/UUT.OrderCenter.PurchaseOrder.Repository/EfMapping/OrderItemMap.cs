using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class OrderItemMap
    {
        public static void SetConfig(EntityTypeBuilder<OrderItem> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_OrderItem");
            entityBuilder.Ignore(p => p.TotalPrice);
            entityBuilder.Ignore(i => i.Tourists);

            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(p => p.ProductType).IsRequired();
            entityBuilder.Property(p => p.ProductName).IsRequired();
            entityBuilder.Property(p => p.ItemName).IsRequired();
            entityBuilder.Property(p => p.CurrencyCode).IsRequired();
            entityBuilder.HasOne(i => i.RequirementItem).WithMany(r => r.OrderItems).HasForeignKey("RequirementItem_Id");

#if EFCore
            entityBuilder.Property(i => i.UserCreatedId).HasColumnName("UserCreated_Id");
            entityBuilder.Property(i => i.UserCreatedFullName).HasColumnName("UserCreated_FullName");
            entityBuilder.Property(i => i.UserCreatedPhone).HasColumnName("UserCreated_Phone");
            entityBuilder.Property(i => i.UserCreatedAgencyId).HasColumnName("UserCreated_AgencyId");
            entityBuilder.Property(i => i.UserCreatedAgencyName).HasColumnName("UserCreated_AgencyName");

            entityBuilder.Property(i => i.PriceConcessionType).HasColumnName("PriceConcession_ConcessionType");
            entityBuilder.Property(i => i.PriceConcessionName).HasColumnName("PriceConcession_ConcessionName");
            entityBuilder.Property(i => i.PriceConcessionNumber).HasColumnName("PriceConcession_ConcessionNumber");

            entityBuilder.Property(i => i.UseDatesJson).HasColumnName("UseDates");

            entityBuilder.Ignore(i => i.UseDates);
            entityBuilder.Ignore(i => i.PriceConcession);
#endif


        }
    }
}
