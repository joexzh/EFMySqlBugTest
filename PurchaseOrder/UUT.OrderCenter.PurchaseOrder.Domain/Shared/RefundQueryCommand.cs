using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Shared
{
    /// <summary>
    /// 退货单查询条件
    /// </summary>
    public class RefundQueryCommand
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// 退货单号
        /// </summary>
        public string RefundNumber { get; set; }
        /// <summary>
        /// 业务状态
        /// </summary>
        public RefundBusinessState? State { get; set; }
        /// <summary>
        /// 卖家号
        /// </summary>
        public long? SellerId { get; set; }
        /// <summary>
        /// 机构名
        /// </summary>
        public string AgencyName { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 申请人姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 审核状态
        /// </summary>
        public VerificationState? VerificationState { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
