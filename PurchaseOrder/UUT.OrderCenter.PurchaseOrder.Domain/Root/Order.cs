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
using UUT.OrderCenter.PurchaseOrder.Domain.Shared;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.OrderState;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.OrderState.Impl;
using UUT.Common.EnumHelper;
using static UUT.OrderCenter.PurchaseOrder.Infrastructure.Config;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Root
{
    public class Order : AggregateRoot
    {
        private OrderBusinessState _businessState = OrderBusinessState.Draft;
        private OrderState _orderState;
        private List<Tourist> _removedTourists = new List<Tourist>();
        private List<OrderAttachment> _removedAttachments = new List<OrderAttachment>();
        string _orderNumber;

        private Order()
        {
            _orderState = new DraftState(this);
        }

        public Order(OrderSource orderSource, string mallOrderId = null) : this()
        {
            OrderSource = orderSource;
        }

        /// <summary>
        /// 订单号, 必填
        /// </summary>
        public string OrderNumber
        {
            get { return _orderNumber; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "订单号不能为空"));
                _orderNumber = value;
            }
        }
        /// <summary>
        /// 订单来源, 默认线下
        /// </summary>
        public OrderSource OrderSource { get; private set; } = OrderSource.OffLine;
        /// <summary>
        /// 订单类型, 若多个产品类型为DIY
        /// </summary>
        public ProductType OrderType { get; private set; } = ProductType.DIY;

        /// <summary>
        /// 产品名称, 多个产品用","分隔
        /// </summary>
        public string ProductName
        {
            get
            {
                var productNames = OrderItems.Select(i => i.ProductName).Distinct();
                return string.Join(",", productNames);
            }
        }

        /// <summary>
        /// 交易模式
        /// </summary>
        public TradeMode TradeMode { get; private set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderBusinessState BusinessState
        {
            get { return _businessState; }
            private set
            {
                _businessState = value;
                _orderState = OrderStateFactory.Create(this, value);
            }
        }

        /// <summary>
        /// 付款状态
        /// <para>所有付款计划为未付款</para>
        /// <para>存在且非所有付款计划为付款中</para>
        /// <para>所有付款计划为已付款</para>
        /// </summary>
        public PayState PayState { get; private set; } = PayState.NotPaid;

        /// <summary>
        /// 审核状态
        /// </summary>
        public VerificationState VerificationState { get; private set; } = VerificationState.Verified;

        /// <summary>
        /// 占位类型
        /// </summary>
        public OccupationType OccupationType { get; set; } = OccupationType.Book;

        /// <summary>
        /// 占位结束时间
        /// </summary>
        public DateTime? OccupationTime { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public OrderMoney OrderMoney { get; private set; } = new OrderMoney();

        /// <summary>
        /// 实际订单订单金额, 币种为成交货币 (除去有效退货单)
        /// </summary>
        public decimal DealAmountExceptRefunds
        {
            get
            {
                var validRefunds = Refunds.Where(r => Refund.ValidRefundState.HasFlag(r.RefundBusinessState));
                var refundMoney = validRefunds.Sum(r => r.RefundMoney);
                return OrderMoney.DealAmount - refundMoney;
            }
        }

        /// <summary>
        /// 实际订单订单金额, 币种为本位币 (除去有效退货单)
        /// </summary>
        public decimal BaseAmountExceptRefunds
        {
            get
            {
                return DealAmountExceptRefunds * OrderMoney.CurrencyRate;
            }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 创建人信息
        /// </summary>
        public User UserCreated { get; set; } = new User();
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime TimeCreated { get; private set; } = DateTime.Now;
        /// <summary>
        /// 卖家信息
        /// </summary>
        public Seller Seller { get; set; } = new Seller();
        /// <summary>
        /// 卖家联系信息
        /// </summary>
        public Contact SellerContact { get; set; } = new Contact();

        /// <summary>
        /// 买家联系信息
        /// </summary>
        public Contact BuyerContact { get; set; } = new Contact();

        /// <summary>
        /// 结算
        /// </summary>
        public Settlement Settlement { get; set; } = new Settlement();

        /// <summary>
        /// 发票信息
        /// </summary>
        public Invoice Invoice { get; set; } = new Invoice();
        /// <summary>
        /// 配送信息
        /// </summary>
        public Shipping Shipping { get; set; } = new Shipping();
        /// <summary>
        /// 优惠
        /// </summary>
        public PriceConcession PriceConcession { get; set; } = new PriceConcession();

        /// <summary>
        /// 商城订单id
        /// </summary>
        public string MallOrderId { get; private set; }
        
        /// <summary>
        /// 订单子项
        /// </summary>
        public virtual ICollection<OrderItem> OrderItems { get; private set; } = new Collection<OrderItem>();
        /// <summary>
        /// 操作日志
        /// </summary>
        public virtual ICollection<OperationLog> OperationLogs { get; private set; } = new Collection<OperationLog>();
        /// <summary>
        /// 游客名单
        /// </summary>
        public virtual ICollection<Tourist> Tourists { get; private set; } = new Collection<Tourist>();

        /// <summary>
        /// 订单附件
        /// </summary>
        public virtual ICollection<OrderAttachment> Attachments { get; private set; } = new Collection<OrderAttachment>();

        /// <summary>
        /// 退货单
        /// </summary>
        public virtual ICollection<Refund> Refunds { get; private set; } = new Collection<Refund>();

        /// <summary>
        /// 为了妥协repository的字段, 要删除的客人名单(给Repository用)
        /// </summary>
        public IEnumerable<Tourist> RemovedTourists { get { return _removedTourists; } }

        /// <summary>
        /// 为了妥协repository的字段, 要删除的附件列表(给Repository用)
        /// </summary>
        public IEnumerable<OrderAttachment> RemovedAttachments { get { return _removedAttachments; } }

        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime? CutOffTime { get; private set; }

        /// <summary>
        /// 订单状态类
        /// </summary>
        public OrderState OrderState
        {
            get { return _orderState; }
            private set
            {
                _businessState = value.State;
                _orderState = value;
            }
        }

        /// <summary>
        /// 有效的状态, 除了取消, 作废, 超时之外都是
        /// </summary>
        public static OrderBusinessState ValidBusinessStateFlag
        {
            get
            {
                return OrderBusinessState.Draft |
                    OrderBusinessState.BuyerDealing |
                    OrderBusinessState.WaitingForBuyerConfirm |
                    OrderBusinessState.WaitingForSellerConfirm |
                    OrderBusinessState.UnPaid |
                    OrderBusinessState.Paying |
                    OrderBusinessState.Paid;
            }
        }

        /// <summary>
        /// 完成的订单状态, 未付款/付款中/已付款
        /// </summary>
        public static OrderBusinessState DoneBusinessStateFlag
        {
            get
            {
                return OrderBusinessState.Paid |
                    OrderBusinessState.Paying |
                    OrderBusinessState.UnPaid;
            }
        }

        /// <summary>
        /// 改变订单状态
        /// </summary>
        /// <param name="state"></param>
        public void ChangeOrderState(OrderState state)
        {
            this.OrderState = state;
        }

        /// <summary>
        /// 增加订单项
        /// </summary>
        /// <param name="item"></param>
        public void AddOrderItem(OrderItem item)
        {
            OrderItems.Add(item);
            CalcTotalAmount();
            SetProductType();
            SetCutOffTime();

            ValidateOrderItems();
            OrderMoney.DealCurrencyCode = OrderItems.First().CurrencyCode;
        }

        /// <summary>
        /// 移除订单项
        /// </summary>
        /// <param name="id"></param>
        public void RemoveOrderItem(Guid id)
        {
            var orderItem = OrderItems.SingleOrDefault(i => i.Id == id);
            if (orderItem == null) return;

            orderItem.Delete();
            OrderItems.Remove(orderItem);
            CalcTotalAmount();
            SetProductType();
            SetCutOffTime();
        }

        /// <summary>
        /// 更新OrderItem
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <param name="item">modified parameters</param>
        public void UpdateOrderItem(Guid orderItemId, OrderItem item)
        {
            var orderItem = this.OrderItems.SingleOrDefault(i => i.Id == orderItemId);
            if (orderItem != null)
            {
                orderItem.Update(item);
                CalcTotalAmount();
                SetProductType();
                SetCutOffTime();

                ValidateOrderItems();
            }
        }

        /// <summary>
        /// 增加游客
        /// </summary>
        /// <param name="tourist"></param>
        public void AddTourist(Tourist tourist)
        {
            Tourists.Add(tourist);
        }

        /// <summary>
        /// 移除游客
        /// </summary>
        /// <param name="touristId"></param>
        public void RemoveTourist(Guid touristId)
        {
            var tourist = Tourists.SingleOrDefault(t => t.Id == touristId);
            if (tourist == null) return;

            Tourists.Remove(tourist);
            _removedTourists.Add(tourist);
        }

        /// <summary>
        /// 增加附件
        /// </summary>
        /// <param name="attachment"></param>
        public void AddAttachment(OrderAttachment attachment)
        {
            Attachments.Add(attachment);
        }

        /// <summary>
        /// 删除附件
        /// </summary>
        /// <param name="attachmentId"></param>
        public void RemoveAttachment(Guid attachmentId)
        {
            var attachment = Attachments.SingleOrDefault(a => a.Id == attachmentId);
            Attachments.Remove(attachment);
            _removedAttachments.Add(attachment);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="src"></param>
        public void Update(Order src)
        {
            Mapper.Map(src, this);

            SetTradeMode();
            CalcTotalAmount();
        }

        /// <summary>
        /// 增加订单
        /// </summary>
        public void Add()
        {
            if (string.IsNullOrEmpty(Seller.SellerName)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "卖家名称不能为空"));

            foreach (var orderItem in OrderItems)
            {
                orderItem.Add();
            }
        }

        /// <summary>
        /// 预delete, 不满足条件直接 throw OperationException.
        /// </summary>
        public void Delete()
        {
            if (BusinessState != OrderBusinessState.Draft)
                throw new OperationException(new OperationError(null, "只允许删除草稿"));
            
        }

        /// <summary>
        /// 提交订单
        /// </summary>
        public void Submit()
        {
            OrderState.SubmitModified();
            ValidateSubmitedOrder();
        }
        
        /// <summary>
        /// 确认订单
        /// </summary>
        public void Confirm()
        {
            OrderState.Next();
            foreach (var orderItem in OrderItems)
            {
                orderItem.Confirm();
            }
        }

        /// <summary>
        /// 取消/作废订单
        /// </summary>
        public void Cancel()
        {
            OrderState.Cancel();
            foreach (var orderItem in OrderItems)
            {
                orderItem.Cancel();
            }
        }

        private void CalcTotalAmount() // 计算总金额
        {
            OrderMoney.DealAmount = 0;
            foreach (var orderItem in this.OrderItems)
            {
                OrderMoney.DealAmount += orderItem.TotalPrice;
            }
            OrderMoney.DealAmount += PriceConcession.ConcessionNumber;
        }

        private void SetProductType() // 设置订单产品类型
        {
            var types = OrderItems.Select(i => i.ProductType).Distinct();
            var count = types.Count();
            if (count > 1)
            {
                OrderType = ProductType.DIY;
            }
            else if (count == 1)
            {
                OrderType = types.First();
            }
        }

        private void ValidateSubmitedOrder() // 验证订单提交前数据
        {
            Shipping.Validate();
            Seller.Validate();
            Settlement.Validate();
            Invoice.Validate();
            PriceConcession.Validate();
            OrderMoney.Validate();

            foreach (var orderItem in OrderItems)
            {
                orderItem.Validate();
            }

            if (!Enum.IsDefined(typeof(OccupationType), OccupationType))
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, $"非法{nameof(OccupationType)}"));
        }

        private void SetTradeMode() // 设置交易模式
        {
            if (UserCreated.AgencyId == null && Seller.SellerType == SellerType.Personal)
                TradeMode = TradeMode.C2C;
            else if (UserCreated.AgencyId == null && Seller.SellerType == SellerType.Agency)
                TradeMode = TradeMode.B2C;
            else if (UserCreated.AgencyId != null && Seller.SellerType == SellerType.Personal)
                TradeMode = TradeMode.C2B;
            else if (UserCreated.AgencyId != null && Seller.SellerType == SellerType.Agency)
                TradeMode = TradeMode.B2B;
        }

        private void SetCutOffTime() // 设置截止时间
        {
            var cutOffTimes = OrderItems.Where(i => i.CutOffTime != null).Select(i => i.CutOffTime.Value);
            if (cutOffTimes.Any())
            {
                CutOffTime = cutOffTimes.Min();
            }
            else
            {
                this.CutOffTime = null;
            }
        }

        private void ValidateOrderItems() // 验证订单项
        {
            var crcs = new List<string>();
            foreach (var orderItem in OrderItems)
            {
                crcs.Add(orderItem.CurrencyCode);
                orderItem.Validate();
            }
            if (crcs.Distinct().Count() > 1) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "同一张订单的不能出现多个币种"));
        }
    }
}
