using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl
{
    /// <summary>
    /// 退货完成状态
    /// </summary>
    public class DoneState : RefundState
    {
        public DoneState(Refund refund) : base(refund)
        {
        }

        public override RefundBusinessState State
        {
            get
            {
                return RefundBusinessState.Done;
            }
        }

        public override void Cancel()
        {
            // 暂时不支持作废
            //Refund.ChangeState(new WaitingForSeller2ConfirmInvalidationState(Refund));
        }

        public override void Next()
        {
            throw new OperationException(new OperationError(null, "完成的退货单不能提交"));
        }
    }
}
