using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class OperationLogMap
    {
        public OperationLogMap(EntityTypeBuilder<OperationLog> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order_OperationLog");
            //Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            entityBuilder.HasKey(p => p.Id);
        }
    }
}
