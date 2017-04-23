using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 操作类型 (for log)
    /// </summary>
    public enum OperationType
    {
        Submit = 1,
        Modify = 2,
        Save = 3,
        Confirm = 4,
        Cancel = 5,
        /// <summary>
        /// 作废
        /// </summary>
        InValidate = 6,
        /// <summary>
        /// 付款
        /// </summary>
        Pay = 7,
        /// <summary>
        /// 确认付款
        /// </summary>
        PayConfirm = 8
    }
}
