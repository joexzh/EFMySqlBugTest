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
    /// 结算
    /// </summary>
    public class Settlement
    {
        /// <summary>
        /// 结算方案类型
        /// </summary>
        public SettlementSchemeType SettlementSchemeType { get; set; } = SettlementSchemeType.Protocol;

        /// <summary>
        /// 结算方式
        /// </summary>
        public SettlementType SettlementType { get; set; } = SettlementType.Immediate;

        /// <summary>
        /// 第几天(只针对月/季/年结)
        /// </summary>
        public int? Day { get; set; }

        /// <summary>
        /// 星期几(只针对周结)
        /// </summary>
        public Weekday? Weekday { get; set; }

        /// <summary>
        /// 结算子项(只针对结算方式: 分次), 不能为空
        /// <para>数组, eg: [] 或 [{"Money":1,"Date":new Date}]</para>
        /// </summary>
        public SettlementItemComplexType SettlementItems { get; set; } = new SettlementItemComplexType();

        /// <summary>
        /// 定金
        /// </summary>
        public decimal? Deposit { get; set; }

        /// <summary>
        /// 定金币种code: CNY/USD/...
        /// </summary>
        public string DepositCurrencyCode { get; set; }

        public void Validate()
        {
            if (!Enum.IsDefined(typeof(SettlementSchemeType), SettlementSchemeType))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"非法{nameof(SettlementSchemeType)}"));

            if (!Enum.IsDefined(typeof(SettlementType), SettlementType))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"非法{nameof(SettlementType)}"));

            if ((SettlementType.Month | SettlementType.Season | SettlementType.Year).HasFlag(SettlementType) && Day == null)
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"结算日不能为空"));
            }

            if (SettlementType == SettlementType.Week && !Enum.IsDefined(typeof(Weekday), Weekday))
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"周结日不能为空"));
            }

            if (SettlementType == SettlementType.Apart && SettlementItems.Count < 1)
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, "分次结算必须包含子项"));
            }

            if (Deposit != null && string.IsNullOrEmpty(DepositCurrencyCode))
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, "请输入缺少定金币种"));
            }
        }
    }
}
