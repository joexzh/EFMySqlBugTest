using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 退货单状态
    /// </summary>
    [Flags]
    public enum RefundBusinessState
    {
        /// <summary>
        /// 草稿
        /// </summary>
        [Description("草稿")]
        Draft = 1,
        /// <summary>
        /// 已提交
        /// </summary>
        [Description("已提交")]
        Submitted = 2,
        /// <summary>
        /// 卖家已受理
        /// </summary>
        [Description("卖家已受理")]
        DealingBySeller = 4,
        /// <summary>
        /// 退货完成
        /// </summary>
        [Description("退货完成")]
        Done = 8,
        /// <summary>
        /// 买家已取消
        /// </summary>
        [Description("买家已取消")]
        CanceledByBuyer = 16,
        /// <summary>
        /// 卖家已取消
        /// </summary>
        [Description("卖家已取消")]
        CanceledBySeller = 32,
        /// <summary>
        /// 已作废
        /// </summary>
        [Description("已作废")]
        Invalidated = 64,
        /// <summary>
        /// 等待买家确认作废
        /// </summary>
        [Description("等待买家确认作废")]
        WaitingForBuyer2ConfirmInvalidation = 128,
        /// <summary>
        /// 等待卖家确认作废
        /// </summary>
        [Description("等待卖家确认作废")]
        WaitingForSeller2ConfirmInvalidation = 256,
        /// <summary>
        /// 买家处理中
        /// </summary>
        [Description("买家处理中")]
        BuyerDealing = 512
    }
}
