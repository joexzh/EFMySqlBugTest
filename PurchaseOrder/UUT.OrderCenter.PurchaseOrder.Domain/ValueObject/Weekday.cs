using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// Week days
    /// </summary>
    [Flags]
    public enum Weekday
    {
        /// <summary>
        /// 星期天
        /// </summary>
        [Description("星期天")]
        Sunday = 1,

        /// <summary>
        /// 星期一
        /// </summary>
        [Description("星期一")]
        Monday = 2,

        /// <summary>
        /// 星期二
        /// </summary>
        [Description("星期二")]
        Tuesday = 4,

        /// <summary>
        /// 星期三
        /// </summary>
        [Description("星期三")]
        Wednesday = 8,

        /// <summary>
        /// 星期四
        /// </summary>
        [Description("星期四")]
        Thursday = 16,

        /// <summary>
        /// Friday
        /// </summary>
        [Description("星期五")]
        Friday = 32,

        /// <summary>
        /// Saturday
        /// </summary>
        [Description("星期六")]
        Saturday = 64
    }
}
