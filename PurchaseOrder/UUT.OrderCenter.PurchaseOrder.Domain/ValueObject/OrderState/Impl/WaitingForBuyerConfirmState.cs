using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.OrderState.Impl
{
    /// <summary>
    /// 等待买家确认状态
    /// </summary>
    public class WaitingForBuyerConfirmState : OrderState
    {
        public WaitingForBuyerConfirmState(Order order) : base(order)
        {
        }

        public override OrderBusinessState State
        {
            get
            {
                return OrderBusinessState.WaitingForBuyerConfirm;
            }
        }

        public override void Cancel()
        {
            _order.ChangeOrderState(new BuyerCanceledState(_order));
        }

        public override void Next()
        {
            _order.ChangeOrderState(new UnPaidState(_order));
        }
        
        public override void SubmitModified()
        {
            _order.ChangeOrderState(new WaitingForSellerConfirmState(_order));
        }
    }
}
