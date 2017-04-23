using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class TouristMap
    {
        public TouristMap(EntityTypeBuilder<Tourist> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_Tourist");
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(p => p.FullName).IsRequired();
        }
    }
}
