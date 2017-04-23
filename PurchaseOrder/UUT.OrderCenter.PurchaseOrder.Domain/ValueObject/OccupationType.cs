using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 占位类型
    /// </summary>
    public enum OccupationType
    {
        /// <summary>
        /// 切位
        /// </summary>
        [Description("切位")]
        Cut = 1,
        /// <summary>
        /// 预订
        /// </summary>
        [Description("预订")]
        Book = 2,
    }
}
