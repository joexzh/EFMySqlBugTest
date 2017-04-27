using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.RelationTable
{
    /// <summary>
    /// It's a bridge table for storing OrderItemId and TouristId using many to many relationship.
    /// </summary>
    public class OrderItemTourist
    {
        public Guid OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }

        public Guid TouristId { get; set; }
        public Tourist Tourist { get; set; }
    }
}
