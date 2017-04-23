using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.OrderState
{
    /// <summary>
    /// 订单状态抽象
    /// </summary>
    public abstract class OrderState
    {
        protected Order _order;

        public OrderState(Order order)
        {
            _order = order;
        }

        /// <summary>
        /// 订单状态
        /// </summary>
        public abstract OrderBusinessState State { get; }
        /// <summary>
        /// 提交修改
        /// </summary>
        public abstract void SubmitModified();
        /// <summary>
        /// 下一个正常状态
        /// </summary>
        public abstract void Next();
        /// <summary>
        /// 取消/作废订单
        /// </summary>
        public abstract void Cancel();
    }
}
