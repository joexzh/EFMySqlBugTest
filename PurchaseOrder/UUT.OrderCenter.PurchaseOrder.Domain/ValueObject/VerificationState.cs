using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 审核状态
    /// </summary>
    [Flags]
    public enum VerificationState
    {
        /// <summary>
        /// 审核中
        /// </summary>
        [Description("审核中")]
        Verifying = 1,
        /// <summary>
        /// 已审核
        /// </summary>
        [Description("已通过")]
        Verified = 2,
        /// <summary>
        /// 审核不通过
        /// </summary>
        [Description("不通过")]
        VerifyFailed = 4
    }
}
