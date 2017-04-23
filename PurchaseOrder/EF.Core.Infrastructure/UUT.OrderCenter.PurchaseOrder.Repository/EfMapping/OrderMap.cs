using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Repository.EfMapping
{
    public class OrderMap
    {
        public OrderMap(EntityTypeBuilder<Order> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order");
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.HasMany(o => o.OperationLogs);
            entityBuilder.HasMany(o => o.OrderItems);
            entityBuilder.Ignore(p => p.OrderState);
            entityBuilder.Ignore(p => p.RemovedTourists);
            entityBuilder.Ignore(p => p.ProductName);
            entityBuilder.Property(p => p.OrderNumber).IsRequired();
        }
    }
}
