using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class RequirementItemMap : EntityTypeConfiguration<RequirementItem>
    {
        public RequirementItemMap()
        {
            ToTable("Purchase_RequirementItem");
            //Property(r => r.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            HasKey(p => p.Id);

            HasRequired(i => i.Requirement);

            Property(i => i.ResName).IsRequired();
            Property(i => i.StandardName).IsRequired();

            HasMany(i => i.OrderItems).WithOptional(i => i.RequirementItem);
        }
    }
}
