using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Shared;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;
using static UUT.OrderCenter.PurchaseOrder.Infrastructure.Config;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Root
{
    /// <summary>
    /// 需求项
    /// </summary>
    public class RequirementItem : AggregateRoot
    {
        string _resName;
        string _standardName;
        int _count;
        UseDatesComplexType _useDates = new UseDatesComplexType();
        int _doingCount;
        int _doneCount;
        int _badCount;

        /// <summary>
        /// 关联的需求
        /// </summary>
        public virtual Requirement Requirement { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        public ProductType ProductType { get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        public long ResId { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        public string ResName
        {
            get { return _resName; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "资源名称不能为空"));
                _resName = value;
            }
        }

        /// <summary>
        /// 资源标准名称
        /// </summary>
        public string StandardName
        {
            get { return _standardName; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "资源标准名称不能为空"));
                _standardName = value;
            }
        }

        /// <summary>
        /// 需求量
        /// </summary>
        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 1) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "需求量不能少于1"));
                _count = value;
            }
        }

        /// <summary>
        /// 采购中数量
        /// </summary>
        public int DoingCount
        {
            get => _doingCount;
            set
            {
                if (value < 0) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "采购中数量不能低于0"));
                _doingCount = value;
            }
        }

        /// <summary>
        /// 已采购数量
        /// </summary>
        public int DoneCount
        {
            get => _doneCount;
            set
            {
                if (value < 0) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "已采购数量不能低于0"));
                _doneCount = value;
            }
        }

        /// <summary>
        /// 取消的数量
        /// </summary>
        public int BadCount
        {
            get => _badCount;
            set
            {
                if (value < 0) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "取消采购的数量不能为0"));
                _badCount = value;
            }
        }

        /// <summary>
        /// 需求时间集合
        /// </summary>
        public UseDatesComplexType UseDates
        {
            get { return _useDates; }
            set
            {
                if (value.Count < 1) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "缺少需求时间"));

                value = new UseDatesComplexType(value.OrderBy(t => t));
                _useDates = value;

                StartDate = value.First();
                EndDate = value.Last();
            }
        }

#if EFCore
        public string UseDatesJson { get => UseDates.SerializedValue; set => UseDates.SerializedValue = value; }
#endif

        /// <summary>
        /// 需求时间 - 开始
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// 需求时间 - 结束
        /// </summary>
        public DateTime EndDate { get; private set; }

        /// <summary>
        /// 关联的订单项
        /// </summary>
        public virtual ICollection<OrderItem> OrderItems { get; private set; } = new HashSet<OrderItem>();

        /// <summary>
        /// 已采购的订单项
        /// <para>交易成功、订单执行中、订单执行完毕的采购订单</para>
        /// </summary>
        public IEnumerable<OrderItem> DoneOrderItems
        {
            get
            {
                var orderFinishState = (OrderBusinessState.Paid | OrderBusinessState.UnPaid | OrderBusinessState.Paying);
                return OrderItems.Where(i => orderFinishState.HasFlag(i.Order.BusinessState));
            }
        }

        /// <summary>
        /// 采购中的订单项
        /// <para>草稿, 待买家确认、待卖家确认、待买家处理的采购订单</para>
        /// </summary>
        public IEnumerable<OrderItem> DoingOrderItems
        {
            get
            {
                var orderDoingState = OrderBusinessState.Draft | OrderBusinessState.BuyerDealing | OrderBusinessState.WaitingForBuyerConfirm | OrderBusinessState.WaitingForSellerConfirm;
                return OrderItems.Where(i => orderDoingState.HasFlag(i.Order.BusinessState));
            }
        }

        /// <summary>
        /// 无效的订单项
        /// <para>超时, 取消, 作废的订单</para>
        /// </summary>
        public IEnumerable<OrderItem> BadOrderItems
        {
            get
            {
                var orderBadState = OrderBusinessState.Timeout | OrderBusinessState.BuyerCanceled | OrderBusinessState.SellerCanceled | OrderBusinessState.Invalidated;
                return OrderItems.Where(i => orderBadState.HasFlag(i.Order.BusinessState));
            }
        }

        public bool Equals(RequirementItem other)
        {
            if (Object.ReferenceEquals(other, null)) return false;

            if (Object.ReferenceEquals(this, other)) return true;

            return Id.Equals(other.Id);
        }

        // If Equals() returns true for a pair of objects  
        // then GetHashCode() must return the same value for these objects. 

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
