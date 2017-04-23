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
    /// 订单总金额
    /// </summary>
    public class OrderMoney
    {
        string _dealCurrencyCode;
        string _baseCurrencyCode;
        decimal _dealAmount;

        /// <summary>
        /// 成交金额
        /// </summary>
        public decimal DealAmount
        {
            get { return _dealAmount; }
            set
            {
                if (value > MaxPrice.Value) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "超过价格上限"));
                _dealAmount = value;
            }
        }

        /// <summary>
        /// 成交币种, CNY
        /// </summary>
        public string DealCurrencyCode
        {
            get { return _dealCurrencyCode; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "成交币种不能为空"));
                _dealCurrencyCode = value;
            }
        }

        /// <summary>
        /// 汇率
        /// </summary>
        public decimal CurrencyRate { get; set; }

        /// <summary>
        /// 本位币币种
        /// </summary>
        public string BaseCurrencyCode
        {
            get { return _baseCurrencyCode; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "本位币币种不能为空"));
                _baseCurrencyCode = value;
            }
        }

        /// <summary>
        /// 折算本位币成交金额
        /// </summary>
        public decimal AmountForBaseCurrency { get { return DealAmount * CurrencyRate; } }

        public void Validate()
        {
            if (string.IsNullOrEmpty(DealCurrencyCode))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, "缺少成交币种"));

            if (string.IsNullOrEmpty(BaseCurrencyCode))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, "缺少本位币币种"));

            if (CurrencyRate <= 0) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "成交汇率不能为0"));

            if (DealAmount <= 0) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "成交金额不能为0"));
        }
    }
}
