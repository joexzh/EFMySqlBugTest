using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 结算方式
    /// </summary>
    [Flags]
    public enum SettlementType
    {
        /// <summary>
        /// 自定
        /// </summary>
        Customize = 1,
        /// <summary>
        /// 即结
        /// </summary>
        Immediate = 2,
        /// <summary>
        /// 次结
        /// </summary>
        Next = 4,
        /// <summary>
        /// 周结
        /// </summary>
        Week = 8,
        /// <summary>
        /// 月结
        /// </summary>
        Month = 16,
        /// <summary>
        /// 季结
        /// </summary>
        Season = 32,
        /// <summary>
        /// 年结
        /// </summary>
        Year = 64,
        /// <summary>
        /// 现结
        /// </summary>
        Live = 128,
        /// <summary>
        /// 分次
        /// </summary>
        Apart = 256
    }
}
