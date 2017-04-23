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
    /// 配送信息
    /// </summary>
    public class Shipping
    {
        /// <summary>
        /// 配送类型, 是/否 配送
        /// </summary>
        public ShippingType ShippingType { get; set; }
        public string Address { get; set; }

        public void Validate()
        {
            if (ShippingType == ShippingType.Yes && string.IsNullOrEmpty(Address))
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, "配送地址不能为空"));
            }
        }
    }
}
