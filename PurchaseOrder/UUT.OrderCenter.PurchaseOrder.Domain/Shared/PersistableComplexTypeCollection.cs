using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Domain.Shared
{
    /// <summary>
    /// This class is for the Entityframework ComplexType Collection.
    /// You should not perform any query for the complex type collection.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class PersistableComplexTypeCollection<T> : Collection<T>
    {
        public PersistableComplexTypeCollection() : base(new Collection<T>())
        {
            
        }

        public PersistableComplexTypeCollection(IEnumerable<T> elements) : base(elements.ToList())
        {
            
        }

        public virtual string SerializedValue
        {
            get
            {
                return JsonConvert.SerializeObject(this);
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var items = JsonConvert.DeserializeObject<Collection<T>>(value);
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
