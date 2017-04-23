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
    public class RequirementMap
    {
        public RequirementMap(EntityTypeBuilder<Requirement> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Requirement");
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.HasMany(r => r.RequirementItems);
            entityBuilder.Property(r => r.RequirementNumber).IsRequired();
            entityBuilder.Property(r => r.ResName).IsRequired();
        }
    }
}
