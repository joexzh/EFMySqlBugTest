using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 订单来源
    /// </summary>
    public enum OrderSource
    {
        /// <summary>
        /// 同业商城
        /// </summary>
        [Description("同业商城")]
        PeerMall = 1,
        /// <summary>
        /// 零售商城
        /// </summary>
        [Description("零售商城")]
        RetailMall = 2,
        /// <summary>
        /// 线下交易
        /// </summary>
        [Description("线下交易")]
        OffLine = 3,
        OTA = 4,
    }
}
