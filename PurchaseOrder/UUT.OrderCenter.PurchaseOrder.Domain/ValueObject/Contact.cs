using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 联系人
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 电子邮件地址
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// QQ 号码
        /// </summary>
        public string QQ { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        public string Wechat { get; set; }
        /// <summary>
        /// 微信 QR code 图片路径
        /// </summary>
        public string WechatQrImg { get; set; }
    }
}
