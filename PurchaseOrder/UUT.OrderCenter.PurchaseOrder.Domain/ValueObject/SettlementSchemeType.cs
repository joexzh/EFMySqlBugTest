using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 结算方案类型
    /// </summary>
    public enum SettlementSchemeType
    {
        /// <summary>
        /// 协议结算
        /// </summary>
        [Description("协议结算")]
        Protocol = 1,

        /// <summary>
        /// 产品结算
        /// </summary>
        [Description("产品结算")]
        Product = 2,

        /// <summary>
        /// 订单结算
        /// </summary>
        [Description("订单结算")]
        Order = 4
    }
}
