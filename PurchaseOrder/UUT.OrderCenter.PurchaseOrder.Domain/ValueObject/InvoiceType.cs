using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 发票类型
    /// </summary>
    [Flags]
    public enum InvoiceType
    {
        /// <summary>
        /// 普通发票
        /// </summary>
        [Description("普通发票")]
        Normal = 1,
        /// <summary>
        /// 增值税发票
        /// </summary>
        [Description("增值税发票")]
        VAT = 2,
        /// <summary>
        /// 不开发票
        /// </summary>
        [Description("不开发票")]
        None = 4
    }
}
