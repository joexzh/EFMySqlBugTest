using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;
using static UUT.OrderCenter.PurchaseOrder.Infrastructure.Config;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Root
{
    /// <summary>
    /// 订单项
    /// <para>术语: 产品项 = 报价项/附加项/资源</para>
    /// </summary>
    public class OrderItem : Shared.AggregateRoot
    {
        string _productName;
        string _itemName;
        int _count;
        decimal _taxRate;
        string _currencyCode;
        decimal _unitPrice;

        public OrderItem()
        {
        }

        /// <summary>
        /// 关联的订单
        /// </summary>
        public virtual Order Order { get; set; }

        /// <summary>
        /// 关联的需求项
        /// </summary>
        public virtual RequirementItem RequirementItem { get; set; }

        /// <summary>
        /// 当前产品Id, 新增时必填, 线下订单请忽略此字段
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 产品编号，线下订单忽略此字段
        /// </summary>
        public string ProductNumber { get; set; }

        /// <summary>
        /// 上游产品Id
        /// </summary>
        public string PreProductId { get; set; }
        /// <summary>
        /// 原始产品Id
        /// </summary>
        public string OriginProductId { get; set; }
        /// <summary>
        /// 产品名称, 新增时必填, 线下订单即资源名称
        /// </summary>
        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(null, "产品名称不能为空"));
                _productName = value;
            }
        }

        /// <summary>
        /// 产品报价项id, 来自产品中心, 用于验证订单
        /// <para>线下订单请忽略此字段</para>
        /// </summary>
        public string ProductItemId { get; set; }

        /// <summary>
        /// 产品封面图路径
        /// </summary>
        public string ProductImgPath { get; set; }
        /// <summary>
        /// 产品供应商Id
        /// </summary>
        public long? SupplierId { get; set; }
        /// <summary>
        /// 产品供应商名称
        /// </summary>
        public string SupplierName { get; set; }

        /// <summary>
        /// 产品类型, 默认是DIY, 新增时必填
        /// </summary>
        public ProductType ProductType { get; set; } = ProductType.DIY;
        /// <summary>
        /// 订单项名称, 线下订单即资源标准名称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(null, "订单项名称不能为空"));
                _itemName = value;
            }
        }

        /// <summary>
        /// 产品项单价
        /// </summary>
        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (value < 0) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "单价不能小于0"));
                if (value > MaxPrice.Value) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "超过价格上限"));

                _unitPrice = value;
            }
        }

        /// <summary>
        /// 使用日期集合, 酒店类型必填
        /// </summary>
        public UseDatesComplexType UseDates { get; set; } = new UseDatesComplexType();

        /// <summary>
        /// 使用时间备注
        /// </summary>
        public string UseTimeNote { get; set; }

        /// <summary>
        /// 订单项币种 ISO 代码
        /// </summary>
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "订单项币种编号不能为空: " + ItemName));
                _currencyCode = value;
            }
        }

        /// <summary>
        /// 订单项数量, 新增时必填
        /// </summary>
        public int Count
        {
            get { return _count; }
            set
            {
                if (value < 1) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "订单项数量不能少于1"));
                _count = value;
            }
        }

        /// <summary>
        /// 产品项总金额 = (单价 + 单品优惠) * 数量 * (1 + 税率), 只读
        /// </summary>
        public decimal TotalPrice
        {
            get
            {
                return (UnitPrice + PriceConcession?.ConcessionNumber ?? 0) * Count * (1 + TaxRate);
            }
        }
        /// <summary>
        /// 产品优惠, 新增时必填
        /// </summary>
        public PriceConcession PriceConcession { get; set; } = new PriceConcession();

        /// <summary>
        /// 税率
        /// </summary>
        public decimal TaxRate
        {
            get { return _taxRate; }
            set
            {
                if (value < 0) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "订单项税率不能少于0"));
                _taxRate = value;
            }
        }

        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime? CutOffTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public User UserCreated { get; set; } = new User();

        public DateTime TimeCreated { get; private set; } = DateTime.Now;
        public long UserIdModified { get; set; }
        public DateTime TimeModified { get; private set; } = DateTime.Now;

        /// <summary>
        /// 是否报价项
        /// </summary>
        public bool IsPriceItem { get; set; } = true;

        /// <summary>
        /// 游客名单, 新增订单时禁止使用, 否则报错
        /// </summary>
        public virtual ICollection<Tourist> Tourists { get; private set; } = new Collection<Tourist>();

        /// <summary>
        /// 增加游客
        /// </summary>
        /// <param name="t"></param>
        public void AddTourist(Tourist t)
        {
            Tourists.Add(t);
        }

        /// <summary>
        /// 删除游客
        /// </summary>
        /// <param name="id"></param>
        public void RemoveTourist(Guid id)
        {
            var tourist = Tourists.FirstOrDefault(i => i.Id == id);
            if (tourist == null) return;

            Tourists.Remove(tourist);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="o"></param>
        public void Update(OrderItem o)
        {
            if (RequirementItem != null)
            {
                RequirementItem.DoingCount -= this.Count;
                RequirementItem.DoingCount += o.Count;
            }

            Mapper.Map(o, this);

        }

        public void Validate()
        {
            if (SupplierId != null && string.IsNullOrEmpty(SupplierName))
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"缺少供应商名称: {ItemName}"));
            }

            if (!Enum.IsDefined(typeof(ProductType), ProductType))
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"非法{nameof(ProductType)}"));
            }

            if (ProductType == ProductType.Hotel && !UseDates.Any())
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, "酒店类型订单项缺少使用时间"));
            }

            if (string.IsNullOrEmpty(CurrencyCode))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, "订单项币种不能为空: " + ItemName));

            if (TotalPrice < 0) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "订单项总价不能少于0"));
        }

        /// <summary>
        /// 增加订单项
        /// </summary>
        public void Add()
        {
            if (this.RequirementItem != null)
            {
                RequirementItem.DoingCount += this.Count;
            }
            Validate();
        }

        /// <summary>
        /// 删除订单项
        /// </summary>
        public void Delete()
        {
            if (RequirementItem != null)
            {
                RequirementItem.DoingCount -= Count;
            }
        }

        internal void Cancel()
        {
            if (RequirementItem != null)
            {
                RequirementItem.DoingCount -= Count;
                RequirementItem.BadCount += Count;
            }
        }

        internal void Confirm()
        {
            if (RequirementItem != null)
            {
                RequirementItem.DoingCount -= Count;
                RequirementItem.DoingCount += Count;
            }
        }
    }
}
