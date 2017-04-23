using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UUT.OrderCenter.PurchaseOrder.Infrastructure.Collection
{
    public class MyGroup<TKey, TElement> : List<TElement>, IGrouping<TKey, TElement>
    {
        public TKey Key { get; set; }

        public MyGroup()
        {

        }

        public MyGroup(IEnumerable<TElement> elements)
        {
            foreach (var element in elements)
            {
                this.Add(element);
            }
        }

        public MyGroup(IEnumerable<TElement> elements, TKey key) : this(elements)
        {
            Key = key;
        }
    }
}
