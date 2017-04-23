using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl
{
    /// <summary>
    /// 等待买家确认作废状态
    /// </summary>
    public class WaitingForBuyer2ConfirmInvalidationState : RefundState
    {
        public WaitingForBuyer2ConfirmInvalidationState(Refund refund) : base(refund)
        {
        }

        public override RefundBusinessState State
        {
            get
            {
                return RefundBusinessState.WaitingForBuyer2ConfirmInvalidation;
            }
        }

        public override void Cancel()
        {
            Refund.ChangeState(new DoneState(Refund));
        }

        public override void Next()
        {
            Refund.ChangeState(new InvalidatedState(Refund));
        }
    }
}
