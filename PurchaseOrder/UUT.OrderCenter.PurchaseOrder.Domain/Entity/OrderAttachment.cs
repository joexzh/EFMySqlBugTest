using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Entity
{
    /// <summary>
    /// 订单附件
    /// </summary>
    public class OrderAttachment : Shared.Entity
    {
        /// <summary>
        /// 订单id
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 下载路径
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="attachment"></param>
        public void Update(OrderAttachment attachment)
        {
            Mapper.Map(attachment, this);
        }
    }
}
