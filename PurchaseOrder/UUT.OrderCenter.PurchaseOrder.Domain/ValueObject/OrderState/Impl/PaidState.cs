using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.OrderState.Impl
{
    /// <summary>
    /// 已付款
    /// </summary>
    public class PaidState : OrderState
    {
        public PaidState(Order order) : base(order)
        {
        }

        public override OrderBusinessState State
        {
            get
            {
                return OrderBusinessState.Paid;
            }
        }

        public override void Cancel()
        {
            throw new OperationException(new OperationError(null, "已付款的订单不能取消/作废"));
        }

        public override void Next()
        {
            throw new OperationException(new OperationError(null, "已付款的订单不能进行下一步"));
        }
        
        public override void SubmitModified()
        {
            throw new OperationException(new OperationError(null, "已付款的订单不能提交修改"));
        }
    }
}
