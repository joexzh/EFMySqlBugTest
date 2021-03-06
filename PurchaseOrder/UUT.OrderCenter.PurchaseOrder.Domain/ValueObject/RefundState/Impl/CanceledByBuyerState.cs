﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl
{
    /// <summary>
    /// 买家取消状态
    /// </summary>
    public class CanceledByBuyerState : RefundState
    {
        public CanceledByBuyerState(Refund refund) : base(refund)
        {
        }

        public override RefundBusinessState State
        {
            get
            {
                return RefundBusinessState.CanceledByBuyer;
            }
        }

        public override void Cancel()
        {
            throw new OperationException(new OperationError(null, "取消的退货单不能作废"));
        }

        public override void Next()
        {
            throw new OperationException(new OperationError(null, "取消的退货单不能提交"));
        }
    }
}
