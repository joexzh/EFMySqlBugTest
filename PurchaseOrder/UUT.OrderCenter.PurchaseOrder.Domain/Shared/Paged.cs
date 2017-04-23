using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Shared
{
    public class Paged<T>
    {
        private Paged()
        {

        }

        public Paged(IEnumerable<T> items, long totalCount)
        {
            Items = items;
            TotalCount = totalCount;
        }

        public IEnumerable<T> Items { get; private set; }
        public long TotalCount { get; private set; }
    }
}
