using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Shared;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 使用时间集合值对象
    /// </summary>
    public class UseDatesComplexType : PersistableComplexTypeCollection<DateTime>
    {
        public UseDatesComplexType(IEnumerable<DateTime> dateTimes) : base(dateTimes)
        {

        }

        public UseDatesComplexType()
        {

        }
    }
}
