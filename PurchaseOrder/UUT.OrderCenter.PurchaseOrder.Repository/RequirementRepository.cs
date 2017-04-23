using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Infrastructure.Interface;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;
using UUT.OrderCenter.PurchaseOrder.Repository.Interface;
using System.Data.Entity;

namespace UUT.OrderCenter.PurchaseOrder.Repository
{
    public class RequirementRepository : Repository<Requirement>, IRequirementRepository
    {
        public RequirementRepository(IDbContext dbCtx) : base(dbCtx)
        {
        }

        public override async Task<Requirement> GetByIdAsync(dynamic id)
        {
            var guid = (Guid)id;
            return await Context.Set<Requirement>().Where(r => r.Id == guid).Include(r => r.RequirementItems).FirstAsync();
        }
    }
}
