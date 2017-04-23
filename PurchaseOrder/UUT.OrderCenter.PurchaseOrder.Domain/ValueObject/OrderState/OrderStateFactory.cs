using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.OrderState.Impl;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.OrderState
{
    public class OrderStateFactory
    {
        public static OrderState Create(Order order, OrderBusinessState businessState)
        {
            return Activator.CreateInstance(_map[businessState], order) as OrderState;
        }

        private static ReadOnlyDictionary<OrderBusinessState, Type> _map = new ReadOnlyDictionary<OrderBusinessState, Type>(new Dictionary<OrderBusinessState, Type>()
        {
            [OrderBusinessState.Draft] = typeof(DraftState),
            [OrderBusinessState.Paid] = typeof(PaidState),
            [OrderBusinessState.UnPaid] = typeof(UnPaidState),
            [OrderBusinessState.Paying] = typeof(PayingState),
            [OrderBusinessState.BuyerCanceled] = typeof(BuyerCanceledState),
            [OrderBusinessState.SellerCanceled] = typeof(SellerCanceledState),
            [OrderBusinessState.Invalidated] = typeof(InvalidatedState),
            [OrderBusinessState.WaitingForBuyerConfirm] = typeof(WaitingForBuyerConfirmState),
            [OrderBusinessState.WaitingForSellerConfirm] = typeof(WaitingForSellerConfirmState),
            [OrderBusinessState.Timeout] = typeof(TimeoutState),
            [OrderBusinessState.BuyerDealing] = typeof(BuyerDealingState)
        });
    }
}
