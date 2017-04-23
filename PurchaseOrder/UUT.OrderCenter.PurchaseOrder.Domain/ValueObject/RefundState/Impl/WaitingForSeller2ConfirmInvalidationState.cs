using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl
{
    /// <summary>
    /// 当代卖家确认作废状态
    /// </summary>
    public class WaitingForSeller2ConfirmInvalidationState : RefundState
    {
        public WaitingForSeller2ConfirmInvalidationState(Refund refund) : base(refund)
        {
        }

        public override RefundBusinessState State
        {
            get
            {
                return RefundBusinessState.WaitingForSeller2ConfirmInvalidation;
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
