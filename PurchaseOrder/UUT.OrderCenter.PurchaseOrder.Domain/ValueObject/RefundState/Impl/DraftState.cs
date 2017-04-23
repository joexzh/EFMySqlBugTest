using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl
{
    public class DraftState : RefundState
    {
        public DraftState(Refund refund) : base(refund)
        {
        }

        public override RefundBusinessState State
        {
            get
            {
                return RefundBusinessState.Draft;
            }
        }

        public override void Cancel()
        {
            throw new OperationException(new OperationError(null, "草稿退货单无法取消"));
        }

        public override void Next()
        {
            Refund.ChangeState(new DealingBySellerState(Refund));
        }
    }
}
