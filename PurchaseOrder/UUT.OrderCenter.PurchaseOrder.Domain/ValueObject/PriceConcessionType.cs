using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 价格优惠类型
    /// </summary>
    public enum PriceConcessionType
    {
        /// <summary>
        /// 直减
        /// </summary>
        DirectReduce = 1,
        /// <summary>
        /// 折扣
        /// </summary>
        Discount = 2
    }
}
