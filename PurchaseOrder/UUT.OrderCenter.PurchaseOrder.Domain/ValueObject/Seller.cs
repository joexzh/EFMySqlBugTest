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
    /// 卖家信息
    /// <para>线下对象, 卖家id为空</para>
    /// <para>卖家 id 为机构或个人 id. 这设计也是醉了, 后面拭目以待, 如何收场</para>
    /// </summary>
    public class Seller
    {
        private string _sellerName;

        /// <summary>
        /// 线上/线下
        /// </summary>
        public SellerOnlineType OnlineType { get; set; }
        /// <summary>
        /// 个人/机构
        /// </summary>
        public SellerType SellerType { get; set; }
        /// <summary>
        /// 卖家Id. 个人 id/机构 id
        /// </summary>
        public long SellerId { get; set; }

        /// <summary>
        /// 卖家名称
        /// </summary>
        public string SellerName
        {
            get { return _sellerName; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "卖家名称不能为空"));
                _sellerName = value;
            }
        }

        /// <summary>
        /// 机构关系id, 线下机构必填
        /// </summary>
        public long? AgencyRelationId { get; set; }

        public void Validate()
        {
            if (!Enum.IsDefined(typeof(SellerOnlineType), OnlineType))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"非法{nameof(OnlineType)}类型"));

            if (!Enum.IsDefined(typeof(SellerType), SellerType))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"非法{nameof(SellerType)}类型"));

            if (SellerId <= 0)
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"非法{nameof(SellerId)}值: {SellerId}"));

            if (string.IsNullOrEmpty(SellerName))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"{nameof(SellerName)}不能为为空"));

            if (OnlineType == SellerOnlineType.OffLine && AgencyRelationId == null)
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"线下机构{nameof(AgencyRelationId)}不能为空"));
        }
    }
}
