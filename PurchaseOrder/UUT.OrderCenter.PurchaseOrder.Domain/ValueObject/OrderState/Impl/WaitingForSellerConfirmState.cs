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
    /// 等待卖家确认状态
    /// </summary>
    public class WaitingForSellerConfirmState : OrderState
    {
        public WaitingForSellerConfirmState(Order order) : base(order)
        {
        }

        public override OrderBusinessState State
        {
            get
            {
                return OrderBusinessState.WaitingForSellerConfirm;
            }
        }

        public override void Cancel()
        {
            _order.ChangeOrderState(new BuyerCanceledState(_order));
        }

        /// <summary>
        /// 如果是被销售模块调用, 要允许修改状态
        /// </summary>
        public override void Next()
        {
            _order.ChangeOrderState(new UnPaidState(_order));
            //throw new OperationException(new OperationError(null, "正在等待卖家确认, 买家无法确认"));
        }

        /// <summary>
        /// 如果是被销售模块调用, 要允许修改状态
        /// </summary>
        public override void SubmitModified()
        {
            _order.ChangeOrderState(new WaitingForBuyerConfirmState(_order));
            //throw new OperationException(new OperationError(null, "正在等待卖家确认, 无法提交订单"));
        }
    }
}
