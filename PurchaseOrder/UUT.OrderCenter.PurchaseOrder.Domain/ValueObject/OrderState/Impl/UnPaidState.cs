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
    /// 未付款状态
    /// </summary>
    public class UnPaidState : OrderState
    {
        public UnPaidState(Order order) : base(order)
        {
        }

        public override OrderBusinessState State
        {
            get
            {
                return OrderBusinessState.UnPaid;
            }
        }

        public override void Cancel()
        {
            _order.ChangeOrderState(new InvalidatedState(_order));
        }

        public override void Next()
        {
            _order.ChangeOrderState(new PayingState(_order));
        }
        
        public override void SubmitModified()
        {
            throw new OperationException(new OperationError(null, "未付款的订单不能提交修改"));
        }
    }
}
