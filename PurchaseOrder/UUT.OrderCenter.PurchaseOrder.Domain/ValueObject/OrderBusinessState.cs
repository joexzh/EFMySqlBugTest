using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 订单业务状态
    /// </summary>
    [Flags]
    public enum OrderBusinessState
    {
        /// <summary>
        /// 草稿
        /// </summary>
        [Description("草稿")]
        Draft = 1,
        /// <summary>
        /// 买家处理中
        /// </summary>
        [Description("买家处理中")]
        BuyerDealing = 2,
        /// <summary>
        /// 待卖家确认
        /// </summary>
        [Description("待卖家确认")]
        WaitingForSellerConfirm = 4,
        /// <summary>
        /// 待买家确认
        /// </summary>
        [Description("待买家确认")]
        WaitingForBuyerConfirm = 8,
        /// <summary>
        /// 买家已取消
        /// </summary>
        [Description("买家已取消")]
        BuyerCanceled = 16,
        /// <summary>
        /// 卖家已取消
        /// </summary>
        [Description("卖家已取消")]
        SellerCanceled = 32,
        /// <summary>
        /// 超时
        /// </summary>
        [Description("已超时")]
        Timeout = 64,
        /// <summary>
        /// 订单作废确认中
        /// </summary>
        [Description("作废确认中")]
        InvalidationConfirming = 128,
        /// <summary>
        /// 订单已作废
        /// </summary>
        [Description("已作废")]
        Invalidated = 256,
        /// <summary>
        /// 处理中
        /// </summary>
        [Description("处理中")]
        Processing = 512,
        /// <summary>
        /// 未付款 (交易成功)
        /// </summary>
        [Description("交易成功")]
        UnPaid = 1024,
        /// <summary>
        /// 付款中
        /// </summary>
        [Description("付款中")]
        Paying = 2048,
        /// <summary>
        /// 已付款
        /// </summary>
        [Description("已付款")]
        Paid = 4096,
    }
}
