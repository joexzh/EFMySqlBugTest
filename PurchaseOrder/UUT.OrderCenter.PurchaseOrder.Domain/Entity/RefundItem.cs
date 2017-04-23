using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using static UUT.OrderCenter.PurchaseOrder.Infrastructure.Config;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Entity
{
    /// <summary>
    /// 退货项
    /// </summary>
    public class RefundItem : Shared.Entity
    {
        int _refundCount;

        private RefundItem()
        {

        }

        public RefundItem(Guid refundId)
        {
            RefundId = refundId;
        }

        /// <summary>
        /// 退货单id
        /// </summary>
        public Guid RefundId { get; private set; }

        /// <summary>
        /// 订单项
        /// </summary>
        public virtual OrderItem OrderItem { get; set; }
        /// <summary>
        /// 退货数量
        /// </summary>
        public int RefundCount
        {
            get { return _refundCount; }
            set
            {
                if (value < 1) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "退货数量不能少于1"));
                _refundCount = value;
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="src"></param>
        public void Update(RefundItem src)
        {
            Mapper.Map(src, this);
        }

        public void Validate()
        {
            if (OrderItem == null) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "退货项关联的订单项不能为空"));
        }
    }
}
