using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState
{
    public class RefundStateFactory
    {
        public static RefundState Create(RefundBusinessState refundState, Refund refund)
        {
            return Activator.CreateInstance(_map[refundState], refund) as RefundState;
        }

        private static ReadOnlyDictionary<RefundBusinessState, Type> _map = new ReadOnlyDictionary<RefundBusinessState, Type>(new Dictionary<RefundBusinessState, Type>()
        {
            [RefundBusinessState.Draft] = typeof(DraftState),
            [RefundBusinessState.Submitted] = typeof(SubmittedState),
            [RefundBusinessState.DealingBySeller] = typeof(DealingBySellerState),
            [RefundBusinessState.CanceledByBuyer] = typeof(CanceledByBuyerState),
            [RefundBusinessState.CanceledBySeller] = typeof(CanceledBySellerState),
            [RefundBusinessState.WaitingForBuyer2ConfirmInvalidation] = typeof(WaitingForBuyer2ConfirmInvalidationState),
            [RefundBusinessState.WaitingForSeller2ConfirmInvalidation] = typeof(WaitingForSeller2ConfirmInvalidationState),
            [RefundBusinessState.Invalidated] = typeof(InvalidatedState),
            [RefundBusinessState.Done] = typeof(DoneState),
            [RefundBusinessState.BuyerDealing] = typeof(BuyerDealingState)
        });
    }
}
