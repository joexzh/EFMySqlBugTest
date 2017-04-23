using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class RequirementMap : EntityTypeConfiguration<Requirement>
    {
        public RequirementMap()
        {
            ToTable("Purchase_Requirement");
            //Property(r => r.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            HasKey(p => p.Id);

            HasMany(r => r.RequirementItems);

            Property(r => r.RequirementNumber).IsRequired();
            Property(r => r.ResName).IsRequired();
        }
    }
}
