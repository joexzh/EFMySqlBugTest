using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 支付状态
    /// </summary>
    public enum PayState
    {
        /// <summary>
        /// 所有付款计划为未付款
        /// </summary>
        [Description("未付款")]
        NotPaid = 1,
        /// <summary>
        /// 存在且非所有付款计划为付款中
        /// </summary>
        [Description("付款中")]
        Paying = 2,
        /// <summary>
        /// 所有付款计划为已付款
        /// </summary>
        [Description("已结清")]
        Paid = 3
    }
}
