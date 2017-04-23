using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Shared
{
    public class OrderQueryCommand
    {
        private DateTime? _endDate;

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 卖家类型
        /// </summary>
        public SellerType? SellerType { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        public long? SellerId { get; set; }

        /// <summary>
        /// 卖家名称
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// 付款状态
        /// </summary>
        public PayState? PayState { get; set; }

        /// <summary>
        /// 订单业务状态, 多个状态的值相加可以获取对应的多个状态的订单
        /// </summary>
        public OrderBusinessState? BusinessState { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public VerificationState? VerificationState { get; set; }

        /// <summary>
        /// 下单日期-开始
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 下单日期-结束
        /// </summary>
        public DateTime? EndDate
        {
            get { return _endDate; }
            set
            {
                if (value.HasValue) // 补偿过度的精确
                {
                    value = value.Value.AddDays(1);
                }
                _endDate = value;
            }
        }

        /// <summary>
        /// 下单人
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        public OrderSource? OrderSource { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public ProductType? OrderType { get; set; }

        public string MallOrderId { get; set; }
        
        public int PageIndex { get; set; }

        public int PageSize { get; set; }
    }
}
