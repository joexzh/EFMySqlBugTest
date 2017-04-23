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
    /// 草稿状态实现
    /// </summary>
    public class DraftState : OrderState
    {
        public DraftState(Order order) : base(order)
        {
        }

        public override OrderBusinessState State
        {
            get
            {
                return OrderBusinessState.Draft;
            }
        }

        public override void Cancel()
        {
            throw new OperationException(new OperationError(null, "草稿订单不能取消/作废"));
        }

        public override void Next()
        {
            throw new OperationException(new OperationError(null, "草稿订单不能确认"));
        }
        
        public override void SubmitModified()
        {
            _order.ChangeOrderState(new BuyerDealingState(_order));
        }
    }
}
