using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl
{
    public class InvalidatedState : RefundState
    {
        public InvalidatedState(Refund refund) : base(refund)
        {
        }

        public override RefundBusinessState State
        {
            get
            {
                return RefundBusinessState.Invalidated;
            }
        }

        public override void Cancel()
        {
            throw new OperationException(new OperationError(null, "作废的退货单不能取消"));
        }

        public override void Next()
        {
            throw new OperationException(new OperationError(null, "作废的退货单不能提交"));
        }
    }
}
