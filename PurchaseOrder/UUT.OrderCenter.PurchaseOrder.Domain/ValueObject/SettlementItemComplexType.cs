using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Shared;

namespace UUT.OrderCenter.PurchaseOrder.Domain.ValueObject
{
    /// <summary>
    /// 订单子项持久化集合
    /// </summary>
    public class SettlementItemComplexType : PersistableComplexTypeCollection<SettlementItem>
    {
        public override string SerializedValue
        {
            get
            {
                return JsonConvert.SerializeObject(this);
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var items = JsonConvert.DeserializeObject<Collection<SettlementItem>>(value);
                    this.Clear();
                    foreach (var item in items)
                    {
                        this.Add(item);
                    }
                }
            }
        }
    }
}
