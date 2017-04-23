using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 结算子项(只针对分次结算)
    /// </summary>
    public class SettlementItem
    {
        /// <summary>
        /// 结算金额
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// 结算日期
        /// </summary>
        public DateTime Date { get; set; }
    }
}
