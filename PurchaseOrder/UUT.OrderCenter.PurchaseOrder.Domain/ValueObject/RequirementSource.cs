using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 需求来源
    /// </summary>
    [Flags]
    public enum RequirementSource
    {
        /// <summary>
        /// 手工录入
        /// </summary>
        [Description("手工录入")]
        Manual = 1,
        /// <summary>
        /// 团队中心
        /// </summary>
        [Description("团队中心")]
        TeamCenter = 2,
    }
}
