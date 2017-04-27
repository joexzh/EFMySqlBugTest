using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Entity
{
    public class OperationLog : Shared.Entity
    {
        public Guid OrderId { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public OperationType OperationType { get; set; }
        /// <summary>
        /// 操作内容
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperatedTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 操作人
        /// </summary>
        public User OperatedUser { get; set; }

#if EFCore
        public long OperatedUserId { get => OperatedUser.Id; set => OperatedUser.Id = value; }

        public string OperatedUserFullName { get => OperatedUser.FullName; set => OperatedUser.FullName = value; }

        public string OperatedUserPhone { get => OperatedUser.Phone; set => OperatedUser.Phone = value; }

        public long? OperatedUserAgencyId { get => OperatedUser.AgencyId; set => OperatedUser.AgencyId = value; }

        public string OperatedUserAgencyName { get => OperatedUser.AgencyName; set => OperatedUser.AgencyName = value; }
#endif
    }
}
