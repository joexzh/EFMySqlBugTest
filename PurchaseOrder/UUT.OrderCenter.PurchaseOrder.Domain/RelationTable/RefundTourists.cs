using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;

namespace UUT.OrderCenter.PurchaseOrder.Domain.RelationTable
{
    public class RefundTourist
    {
        public Guid RefundId { get; set; }

        public Guid TouristId { get; set; }

        public Tourist Tourist { get; set; }
    }
}
