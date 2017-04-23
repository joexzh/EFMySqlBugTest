using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl
{
    /// <summary>
    /// 卖家处理中
    /// </summary>
    public class DealingBySellerState : RefundState
    {
        public DealingBySellerState(Refund refund) : base(refund)
        {
        }

        public override RefundBusinessState State
        {
            get
            {
                return RefundBusinessState.DealingBySeller;
            }
        }

        public override void Cancel()
        {
            throw new OperationException(new OperationError(null, "受理的退货单不能取消"));
        }

        public override void Next()
        {
            Refund.ChangeState(new DoneState(Refund));
        }
    }
}
