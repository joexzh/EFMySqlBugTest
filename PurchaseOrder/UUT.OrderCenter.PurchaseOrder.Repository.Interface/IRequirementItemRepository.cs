using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.Shared;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;

namespace UUT.OrderCenter.PurchaseOrder.Repository.Interface
{
    public interface IRequirementItemRepository : IRepository<RequirementItem>
    {
        /// <summary>
        /// Get paged Groups of requirement items grouped by res id and res standard name
        /// </summary>
        /// <param name="filter">RequirementItem filter</param>
        /// <param name="pageIndex">base on 1</param>
        /// <param name="pageSize"></param>
        /// <param name="includeProperties">includes in RequirementItem</param>
        /// <returns></returns>
        Task<Paged<IGrouping<Tuple<ProductType, string, string>, RequirementItem>>> GetPagedGroupsGroupedByResStandard(
            Expression<Func<RequirementItem, bool>> filter,
            int pageIndex = 0,
            int pageSize = 0,
            string includeProperties = "");

        Task<long> GetCountAsync(Expression<Func<RequirementItem, bool>> filter);
    }
}
