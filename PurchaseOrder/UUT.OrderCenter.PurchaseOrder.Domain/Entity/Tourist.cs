using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.Component.Operation;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Entity
{
    /// <summary>
    /// 游客
    /// <para>An entity can modify itself.</para>
    /// </summary>
    public class Tourist : Shared.Entity
    {
        private string _fullName;

        /// <summary>
        /// 订单id
        /// </summary>
        public Guid OrderId { get; set; }

        /// <summary>
        /// 姓名, 新增时必填
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value ?? throw new OperationException(new OperationError(null, "游客姓名不能为空"));
            }
        }
        /// <summary>
        /// 性别, 新增时必填
        /// </summary>
        public SexType Sex { get; set; }
        /// <summary>
        /// 游客类型, 新增时必填
        /// </summary>
        public TouristType TouristType { get; set; }
        /// <summary>
        /// 身份证号, 新增时必填
        /// </summary>
        public string IdCard { get; set; }
        /// <summary>
        /// 护照号
        /// </summary>
        public string Passport { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 电子邮箱地址
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="tourist"></param>
        public void Update(Tourist tourist)
        {
            Mapper.Map(tourist, this);
        }
    }
}
