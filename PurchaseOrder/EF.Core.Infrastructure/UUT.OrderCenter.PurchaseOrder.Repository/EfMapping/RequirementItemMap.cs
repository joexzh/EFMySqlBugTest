using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class RequirementItemMap
    {
        public static void SetConfig(EntityTypeBuilder<RequirementItem> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_RequirementItem");
            entityBuilder.HasKey(p => p.Id);

            entityBuilder.Ignore(i => i.BadOrderItems);
            entityBuilder.Ignore(i => i.DoingOrderItems);
            entityBuilder.Ignore(i => i.DoneOrderItems);

            entityBuilder.Property(i => i.ResName).IsRequired();
            entityBuilder.Property(i => i.StandardName).IsRequired();
            
#if EFCore
            entityBuilder.Property(i => i.UseDatesJson).HasColumnName("UseDates");

            entityBuilder.Ignore(i => i.UseDates);
#endif
        }
    }
}
