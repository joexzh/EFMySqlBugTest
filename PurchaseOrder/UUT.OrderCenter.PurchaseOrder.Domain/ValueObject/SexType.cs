using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    public enum SexType
    {
        [Description("男")]
        Male = 1,
        [Description("女")]
        Female = 2
    }
}
