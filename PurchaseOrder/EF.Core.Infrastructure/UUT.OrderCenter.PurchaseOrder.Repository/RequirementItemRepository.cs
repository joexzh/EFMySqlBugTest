using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.InfrastructureCore.InterfaceCore;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Domain.Shared;
using UUT.OrderCenter.PurchaseOrder.Domain.ValueObject;
using UUT.OrderCenter.PurchaseOrder.InfrastructureCore.Collection;
using UUT.OrderCenter.PurchaseOrder.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore
{
    public class RequirementItemRepository : Repository<RequirementItem>, IRequirementItemRepository
    {
        public RequirementItemRepository(IDbContext dbCtx) : base(dbCtx)
        {
        }

        public async Task<Paged<IGrouping<Tuple<ProductType, string, string>, RequirementItem>>> GetPagedGroupsGroupedByResStandard(
            Expression<Func<RequirementItem, bool>> filter,
            int pageIndex = 0,
            int pageSize = 0,
            string includeProperties = "")
        {
            IQueryable<RequirementItem> query = Context.Set<RequirementItem>();
            if (filter != null) query = query.Where(filter);

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            var groupQuery = query
                .GroupBy(i => new { i.ResName, i.StandardName, i.ProductType });

            var count = await groupQuery.CountAsync();
            if (pageIndex != 0 && pageSize != 0)
            {
                groupQuery = groupQuery.OrderBy(g => g.Key).Skip(pageSize * (pageIndex - 1)).Take(pageSize);
            }
            var resultGroups = await groupQuery.ToListAsync();

            var myGroups = new List<MyGroup<Tuple<ProductType, string, string>, RequirementItem>>();
            foreach (var resultGroup in resultGroups)
            {
                var myGroup = new MyGroup<Tuple<ProductType, string, string>, RequirementItem>(
                    resultGroup, Tuple.Create(resultGroup.Key.ProductType, resultGroup.Key.ResName, resultGroup.Key.StandardName));
                myGroups.Add(myGroup);
            }

            return new Paged<IGrouping<Tuple<ProductType, string, string>, RequirementItem>>(myGroups, count);
        }

        public async Task<long> GetCountAsync(Expression<Func<RequirementItem, bool>> filter)
        {
            return await Context.Set<RequirementItem>().LongCountAsync(filter);
        }
    }
}
