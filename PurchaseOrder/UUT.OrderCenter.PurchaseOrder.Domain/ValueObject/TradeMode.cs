using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 交易模式
    /// </summary>
    public enum TradeMode
    {
        B2B = 1,
        B2C = 2,
        C2C = 3,
        C2B = 4
    }
}
