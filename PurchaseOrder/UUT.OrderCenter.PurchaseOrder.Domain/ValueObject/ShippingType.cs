using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 配送类型
    /// </summary>
    public enum ShippingType
    {
        /// <summary>
        /// 配送
        /// </summary>
        [Description("配送")]
        Yes = 1,
        /// <summary>
        /// 不配送
        /// </summary>
        [Description("不配送")]
        No = 2
    }
}
