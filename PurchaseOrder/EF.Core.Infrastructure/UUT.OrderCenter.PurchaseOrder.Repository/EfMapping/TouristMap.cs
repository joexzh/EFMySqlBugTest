using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class TouristMap
    {
        public static void SetConfig(EntityTypeBuilder<Tourist> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_Tourist");
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(p => p.FullName).IsRequired();
        }
    }
}
