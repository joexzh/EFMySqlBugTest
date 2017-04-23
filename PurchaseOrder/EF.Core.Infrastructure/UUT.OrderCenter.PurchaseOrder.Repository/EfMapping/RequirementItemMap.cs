using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class RequirementItemMap
    {
        public RequirementItemMap(EntityTypeBuilder<RequirementItem> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_RequirementItem");
            entityBuilder.HasKey(p => p.Id);
            // todo new mapping
            //entityBuilder.HasRequired(i => i.Requirement);
            entityBuilder.Property(i => i.ResName).IsRequired();
            entityBuilder.Property(i => i.StandardName).IsRequired();
            // todo new mapping
            //entityBuilder.HasMany(i => i.OrderItems).WithOptional(i => i.RequirementItem);
        }
    }
}
