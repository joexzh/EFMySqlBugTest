using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 价格上限, 对应mysql (18, 4)
    /// </summary>
    public class MaxPrice
    {
        /// <summary>
        /// 值
        /// </summary>
        public static decimal Value => 99999999999999.99M;
    }
}
