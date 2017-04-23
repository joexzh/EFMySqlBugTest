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
    /// 付款中状态
    /// </summary>
    public class PayingState : OrderState
    {
        public PayingState(Order order) : base(order)
        {
        }

        public override OrderBusinessState State
        {
            get
            {
                return OrderBusinessState.Paying;
            }
        }

        public override void Cancel()
        {
            throw new OperationException(new OperationError(null, "付款中的订单不能取消/作废"));
        }

        public override void Next()
        {
            _order.ChangeOrderState(new PaidState(_order));
        }
        
        public override void SubmitModified()
        {
            throw new OperationException(new OperationError(null, "付款中的订单不能提交修改"));
        }
    }
}
