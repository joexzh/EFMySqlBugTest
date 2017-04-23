using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Shared
{
    /// <summary>
    /// 需求计划查询条件
    /// </summary>
    public class RequirementPlanQueryCommand
    {
        /// <summary>
        /// 产品类型
        /// </summary>
        public ProductType? ProductType { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        public string ResName { get; set; }

        /// <summary>
        /// 标准名称
        /// </summary>
        public string StandardName { get; set; }

        /// <summary>
        /// 需求单号
        /// </summary>
        public string RequirementNumber { get; set; }

        /// <summary>
        /// 需求日期 - 开始
        /// </summary>
        public DateTime? RequirementDateStart { get; set; }

        /// <summary>
        /// 需求日期 - 结束
        /// </summary>
        public DateTime? RequirementDateEnd { get; set; }

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
