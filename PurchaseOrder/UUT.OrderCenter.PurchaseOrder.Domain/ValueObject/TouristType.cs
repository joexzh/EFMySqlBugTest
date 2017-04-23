using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 游客类型
    /// </summary>
    public enum TouristType
    {
        /// <summary>
        /// 成人
        /// </summary>
        [Description("成人")]
        Adult = 1,
        /// <summary>
        /// 儿童
        /// </summary>
        [Description("儿童")]
        Child = 2,
        /// <summary>
        /// 老人
        /// </summary>
        [Description("老人")]
        Old = 3,
        /// <summary>
        /// 婴儿
        /// </summary>
        [Description("婴儿")]
        Baby = 4,
        /// <summary>
        /// 领队/全陪
        /// </summary>
        [Description("领队/全陪")]
        Leader = 5,
        /// <summary>
        /// 司陪
        /// </summary>
        [Description("司陪")]
        Driver = 6
    }
}
