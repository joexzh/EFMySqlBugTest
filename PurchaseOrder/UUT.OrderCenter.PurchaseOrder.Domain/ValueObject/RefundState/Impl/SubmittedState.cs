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
    /// 退货单已提交
    /// </summary>
    public class SubmittedState : RefundState
    {
        public SubmittedState(Refund refund) : base(refund)
        {
        }

        public override RefundBusinessState State
        {
            get
            {
                return RefundBusinessState.Submitted;
            }
        }

        public override void Cancel()
        {
            Refund.ChangeState(new CanceledByBuyerState(Refund));
        }

        public override void Next()
        {
            Refund.ChangeState(new DealingBySellerState(Refund));
        }
    }
}
