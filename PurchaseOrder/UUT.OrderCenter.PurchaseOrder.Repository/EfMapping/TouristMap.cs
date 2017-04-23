using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class TouristMap: EntityTypeConfiguration<Tourist>
    {
        public TouristMap()
        {
            ToTable("Purchase_Order_Tourist");
            //Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(p => p.Id);
            Property(p => p.FullName).IsRequired();
        }
    }
}
