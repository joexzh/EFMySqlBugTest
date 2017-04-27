using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject.RefundState.Impl;
using static UUT.OrderCenter.PurchaseOrder.Infrastructure.Config;
using UUT.OrderCenter.PurchaseOrder.Domain.RelationTable;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Root
{
    /// <summary>
    /// 退货单
    /// </summary>
    public class Refund : Shared.AggregateRoot
    {
        private RefundBusinessState _refundBusinessState = ValueObject.RefundBusinessState.BuyerDealing;
        private RefundState _refundState;
        private List<RefundItem> _removedRefundItems = new List<RefundItem>();
        private List<Tourist> _removedTourists = new List<Tourist>();
        string _refundNumber;
        decimal _refundMoney;

        private Refund() // private constructor is for entity framework
        {
            _refundState = new BuyerDealingState(this);
        }

        /// <summary>
        /// 初始化 Refund 实例
        /// </summary>
        /// <param name="userCreated">user info</param>
        public Refund(User userCreated) : this()
        {
            UserCreated = userCreated;
        }

        /// <summary>
        /// 关联的订单
        /// </summary>
        public virtual Order Order { get; set; }

        /// <summary>
        /// 退货单号
        /// </summary>
        public string RefundNumber
        {
            get { return _refundNumber; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "退货单号不能为空"));
                _refundNumber = value;
            }
        }

        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal RefundMoney
        {
            get { return _refundMoney; }
            set
            {
                if (value < 0) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "退款不能少于0"));
                _refundMoney = value;
            }
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        public User UserCreated { get; private set; } = new User();

#if EFCore
        public long UserCreatedId { get => UserCreated.Id; set => UserCreated.Id = value; }

        public string UserCreatedFullName { get => UserCreated.FullName; set => UserCreated.FullName = value; }

        public string UserCreatedPhone { get => UserCreated.Phone; set => UserCreated.Phone = value; }

        public long? UserCreatedAgencyId { get => UserCreated.AgencyId; set => UserCreated.AgencyId = value; }

        public string UserCreatedAgencyName { get => UserCreated.AgencyName; set => UserCreated.AgencyName = value; }
#endif

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime TimeCreated { get; private set; } = DateTime.Now;

        /// <summary>
        /// 申请说明
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public VerificationState VerificationState { get; set; } = VerificationState.Verified;

        /// <summary>
        /// 退货单状态
        /// </summary>
        public RefundBusinessState RefundBusinessState
        {
            get { return _refundBusinessState; }
            private set
            {
                _refundBusinessState = value;
                _refundState = RefundStateFactory.Create(value, this);
            }
        }

        /// <summary>
        /// 退货项
        /// </summary>
        public virtual ICollection<RefundItem> RefundItems { get; set; } = new Collection<RefundItem>();

        /// <summary>
        /// 退团游客
        /// </summary>
        public virtual ICollection<Tourist> Tourists { get; set; } = new Collection<Tourist>();

#if EFCore
        public ICollection<RefundTourist> RefundTourists { get; set; } = new Collection<RefundTourist>();
#endif

        /// <summary>
        /// 要从退货单中删除的游客, just for EntityFramework remove
        /// </summary>
        public IEnumerable<Tourist> RemovedTourists { get { return _removedTourists; } }

        /// <summary>
        /// 要从退货单中删除的退货项, just for EntityFramework remove
        /// </summary>
        public IEnumerable<RefundItem> RemovedRefundItems { get { return _removedRefundItems; } }

        /// <summary>
        /// 状态类
        /// </summary>
        public RefundState RefundState
        {
            get { return _refundState; }
            private set
            {
                _refundState = value;
                _refundBusinessState = value.State;
            }
        }

        /// <summary>
        /// 合法的退货单状态 (不包含取消, 作废)
        /// </summary>
        public static RefundBusinessState ValidRefundState
        {
            get
            {
                return
                    RefundBusinessState.DealingBySeller |
                    RefundBusinessState.Draft |
                    RefundBusinessState.Done |
                    RefundBusinessState.Submitted |
                    RefundBusinessState.WaitingForBuyer2ConfirmInvalidation |
                    RefundBusinessState.WaitingForSeller2ConfirmInvalidation |
                    RefundBusinessState.BuyerDealing;
            }
        }

        /// <summary>
        /// 改变状态
        /// </summary>
        /// <param name="state"></param>
        public void ChangeState(RefundState state)
        {
            this.RefundState = state;
        }

        /// <summary>
        /// 下一个状态
        /// </summary>
        public void Confirm()
        {
            RefundState.Next();
        }

        /// <summary>
        /// 取消, 回到上一个状态
        /// </summary>
        public void Cancel()
        {
            RefundState.Cancel();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="src"></param>
        public void Update(Refund src)
        {
            Mapper.Map(src, this);
        }

        /// <summary>
        /// 删除
        /// </summary>
        public void Delete()
        {
            if (this.RefundBusinessState != RefundBusinessState.Draft)
            { throw new OperationException(new OperationError(null, "非草稿的退货单不能删除")); }
            return;
        }

        /// <summary>
        /// 增加退货项
        /// </summary>
        /// <param name="item"></param>
        public void AddRefundItem(RefundItem item)
        {
            RefundItems.Add(item);
        }

        /// <summary>
        /// 删除退货项
        /// </summary>
        /// <param name="id"></param>
        public void RemoveRefundItem(Guid id)
        {
            var item = RefundItems.SingleOrDefault(i => i.Id == id);
            if (item != null)
            {
                RefundItems.Remove(item);
                _removedRefundItems.Add(item);
            }
        }
        
        /// <summary>
        /// 增加要退的游客
        /// </summary>
        /// <param name="tourist"></param>
        public void AddTourist(Tourist tourist)
        {
            Tourists.Add(tourist);
        }

        /// <summary>
        /// 删除要退的游客
        /// </summary>
        /// <param name="id"></param>
        public void RemoveTourist(Guid id)
        {
            var tourist = Tourists.SingleOrDefault(t => t.Id == id);
            if (tourist != null)
            {
                Tourists.Remove(tourist);
                _removedTourists.Add(tourist);
            }
        }

        public void Validate()
        {
            if (Order == null) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "退货单关联的订单不能为空"));
            if (RefundMoney <= 0 && RefundItems.Count == 0 && Tourists.Count == 0)
            {
                throw new OperationException(new OperationError(PC_API_ERROR_CODE, "退款金额, 退款货物和退团游客不能同时为空"));
            }

            foreach (var item in RefundItems)
            {
                item.Validate();
            }
        }
    }
}
