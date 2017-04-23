using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState
{
    /// <summary>
    /// 退货单状态抽象类
    /// </summary>
    public abstract class RefundState
    {
        protected Refund Refund { get; private set; }

        public RefundState(Refund refund)
        {
            Refund = refund;
        }

        /// <summary>
        /// 业务状态
        /// </summary>
        public abstract RefundBusinessState State { get; }

        /// <summary>
        /// 取消/作废
        /// </summary>
        public abstract void Cancel();

        /// <summary>
        /// 下一个状态
        /// </summary>
        public abstract void Next();
    }
}
