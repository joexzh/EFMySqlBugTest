using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Shared
{
    /// <summary>
    /// 需求单查询条件
    /// </summary>
    public class RequirementQueryCommand
    {
        /// <summary>
        /// 采购需求号
        /// </summary>
        public string RequirementNumber { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        public string ResName { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public VerificationState? VerificationState { get; set; }

        /// <summary>
        /// 创建时间 - 开始
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 创建时间 - 结束
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string UserNameCreated { get; set; }

        /// <summary>
        /// 页码, 从1开始
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页行数
        /// </summary>
        public int PageSize { get; set; }
    }
}
