using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.OrderState.Impl
{
    public class TimeoutState : OrderState
    {
        public TimeoutState(Order order) : base(order)
        {
        }

        public override OrderBusinessState State
        {
            get
            {
                return OrderBusinessState.Timeout;
            }
        }

        public override void Cancel()
        {
            throw new OperationException(new OperationError(null, "超时的订单不能取消"));
        }

        public override void Next()
        {
            throw new OperationException(new OperationError(null, "超时的订单不能确认"));
        }
        
        public override void SubmitModified()
        {
            throw new OperationException(new OperationError(null, "超时的订单不能提交修改"));
        }
    }
}
