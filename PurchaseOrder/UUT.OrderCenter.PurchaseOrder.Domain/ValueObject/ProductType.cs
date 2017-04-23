using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 产品类型
    /// </summary>
    [Flags]
    public enum ProductType
    {
        /// <summary>
        /// DIY
        /// </summary>
        [Description("DIY")]
        DIY = 1,
        /// <summary>
        /// 线路
        /// </summary>
        [Description("线路")]
        Line = 2,
        /// <summary>
        /// 门票
        /// </summary>
        [Description("门票")]
        Ticket = 4,
        /// <summary>
        /// 酒店
        /// </summary>
        [Description("酒店")]
        Hotel = 8,
        /// <summary>
        /// 餐饮
        /// </summary>
        [Description("餐饮")]
        Meal = 16,
        /// <summary>
        /// 购物点
        /// </summary>
        [Description("购物点")]
        Shopping = 32,
        /// <summary>
        /// 娱乐点
        /// </summary>
        [Description("娱乐点")]
        Entertainment = 64,
        /// <summary>
        /// 汽车
        /// </summary>
        [Description("汽车")]
        Vehicle = 128,
        /// <summary>
        /// 火车
        /// </summary>
        [Description("火车")]
        Train = 256,
        /// <summary>
        /// 飞机
        /// </summary>
        [Description("飞机")]
        Plane = 512,
        /// <summary>
        /// 其它
        /// </summary>
        [Description("其它")]
        Other = 1024,
        /// <summary>
        /// 附加项
        /// </summary>
        [Description("附加项")]
        AdditionalItem = 2048,
    }
}
