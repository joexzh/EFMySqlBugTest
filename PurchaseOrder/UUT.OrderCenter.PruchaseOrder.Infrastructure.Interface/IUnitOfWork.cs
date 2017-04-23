using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUT.OrderCenter.PurchaseOrder.Infrastructure.Interface
{
    /// <summary>
    /// Follow MartinFowler's design pattern, http://martinfowler.com/eaaCatalog/unitOfWork.html
    /// </summary>
    public interface IUnitOfWork
    {
        void RegisterNew<TEntity>(TEntity entity) where TEntity : class;
        void RegisterDirty<TEntity>(TEntity entity) where TEntity : class;
        void RegisterClean<TEntity>(TEntity entity) where TEntity : class;
        void RegisterDeleted<TEntity>(TEntity entity) where TEntity : class;
        Task CommitAsync();
        void Rollback();
    }
}
