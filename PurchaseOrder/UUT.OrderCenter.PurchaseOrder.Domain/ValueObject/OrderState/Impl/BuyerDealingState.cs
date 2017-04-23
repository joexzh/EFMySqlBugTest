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
    /// 买家处理中
    /// </summary>
    public class BuyerDealingState : OrderState
    {
        public BuyerDealingState(Order order) : base(order)
        {
        }

        public override OrderBusinessState State
        {
            get
            {
                return OrderBusinessState.BuyerDealing;
            }
        }

        public override void Cancel()
        {
            _order.ChangeOrderState(new BuyerCanceledState(_order));
        }

        public override void Next()
        {
            throw new OperationException(new OperationError(null, "待买家处理的订单不能确认"));
        }

        public override void SubmitModified()
        {
            if (_order.OrderSource == OrderSource.OffLine)
            {
                _order.ChangeOrderState(new UnPaidState(_order));
                return;
            }

            _order.ChangeOrderState(new WaitingForSellerConfirmState(_order));
        }
    }
}
