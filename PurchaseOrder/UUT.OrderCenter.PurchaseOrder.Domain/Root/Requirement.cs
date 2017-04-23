using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;
using static UUT.OrderCenter.PurchaseOrder.Infrastructure.Config;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Root
{
    /// <summary>
    /// 采购需求
    /// </summary>
    public class Requirement : Shared.AggregateRoot
    {
        string _requirementNumber;
        string _resName;

        private Requirement() { }

        public Requirement(RequirementSource source)
        {
            RequirementSource = source;
        }

        /// <summary>
        /// 需求单号
        /// </summary>
        public string RequirementNumber
        {
            get { return _requirementNumber; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new OperationException(new OperationError(PC_API_ERROR_CODE, "需求单号不能为空"));
                _requirementNumber = value;
            }
        }

        /// <summary>
        /// 资源名称
        /// </summary>
        public string ResName { get; private set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime TimeCreated { get; private set; } = DateTime.Now;

        /// <summary>
        /// 创建用户
        /// </summary>
        public User UserCreated { get; set; } = new User();

        /// <summary>
        /// 需求来源
        /// </summary>
        public RequirementSource RequirementSource { get; private set; }

        /// <summary>
        /// 业务来源id
        /// <para>手工录入业务ID为采购需求ID、团队中心为团计划行程ID</para>
        /// </summary>
        public string BizSourceId { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public VerificationState VerificationState { get; private set; } = VerificationState.Verified;

        /// <summary>
        /// 关联的需求项
        /// </summary>
        public virtual ICollection<RequirementItem> RequirementItems { get; private set; } = new HashSet<RequirementItem>();

        /// <summary>
        /// 增加需求项
        /// </summary>
        /// <param name="item"></param>
        public void AddItems(RequirementItem item)
        {
            RequirementItems.Add(item);
            ResName = string.Join(",", RequirementItems.Select(i => i.ResName));
        }
    }
}
