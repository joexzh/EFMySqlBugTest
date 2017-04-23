using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 机构id, 若非机构用户, 此字段为空
        /// </summary>
        public long? AgencyId { get; set; }

        /// <summary>
        /// 机构名称, 若非机构用户, 此字段为空
        /// </summary>
        public string AgencyName { get; set; }
    }
}
