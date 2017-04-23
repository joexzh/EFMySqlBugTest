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
    /// 发票
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// 发票类型
        /// </summary>
        public InvoiceType InvoiceType { get; set; }
        /// <summary>
        /// 抬头
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        public void Validate()
        {
            if (!Enum.IsDefined(typeof(InvoiceType), InvoiceType))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"非法{nameof(InvoiceType)}"));

            if ((InvoiceType.Normal|InvoiceType.VAT).HasFlag(InvoiceType) && string.IsNullOrEmpty(Title))
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, "缺少发票抬头"));
            }
        }
    }
}
