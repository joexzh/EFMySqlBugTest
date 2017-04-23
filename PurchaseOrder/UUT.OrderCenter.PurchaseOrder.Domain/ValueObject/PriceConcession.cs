using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using static UUT.OrderCenter.PurchaseOrder.Infrastructure.Config;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 价格优惠
    /// </summary>
    public class PriceConcession
    {
        /// <summary>
        /// 优惠类型
        /// </summary>
        public PriceConcessionType ConcessionType { get; set; } = PriceConcessionType.DirectReduce;
        /// <summary>
        /// 优惠名称
        /// </summary>
        public string ConcessionName { get; set; }
        /// <summary>
        /// 优惠数值
        /// </summary>
        public decimal ConcessionNumber { get; set; }

        public void Validate()
        {
            if (!Enum.IsDefined(typeof(PriceConcessionType), ConcessionType))
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"非法{nameof(ConcessionType)}"));
            }
        }
    }
}
