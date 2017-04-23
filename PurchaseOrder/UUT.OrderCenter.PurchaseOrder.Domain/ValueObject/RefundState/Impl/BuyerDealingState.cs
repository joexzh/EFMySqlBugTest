using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl
{
    public class BuyerDealingState : RefundState
    {
        public BuyerDealingState(Refund refund) : base(refund)
        {
        }

        public override RefundBusinessState State => RefundBusinessState.BuyerDealing;

        public override void Cancel()
        {
            Refund.ChangeState(new CanceledByBuyerState(Refund));
        }

        public override void Next()
        {
            if (Refund.Order.OrderSource == OrderSource.OffLine)
            {
                Refund.ChangeState(new DoneState(Refund));
                return;
            }
            Refund.ChangeState(new DealingBySellerState(Refund));
        }
    }
}
