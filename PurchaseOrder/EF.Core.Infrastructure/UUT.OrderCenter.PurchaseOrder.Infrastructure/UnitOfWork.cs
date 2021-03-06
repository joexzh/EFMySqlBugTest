﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UUT.OrderCenter.PurchaseOrder.InfrastructureCore.InterfaceCore;

namespace UUT.OrderCenter.PurchaseOrder.InfrastructureCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _dbCtx;

        public UnitOfWork(IDbContext dbCtx)
        {
            _dbCtx = dbCtx;
        }

        public void RegisterNew<TEntity>(TEntity entity) where TEntity : class
        {
            _dbCtx.Set<TEntity>().Add(entity);
        }

        public void RegisterDirty<TEntity>(TEntity entity) where TEntity : class
        {
            _dbCtx.Entry(entity).State = EntityState.Modified;
        }

        public void RegisterClean<TEntity>(TEntity entity) where TEntity : class
        {
            _dbCtx.Entry(entity).State = EntityState.Unchanged;
        }

        public void RegisterDeleted<TEntity>(TEntity entity) where TEntity : class
        {
            _dbCtx.Entry(entity).State = EntityState.Deleted;
        }

        public async Task CommitAsync()
        {
            await _dbCtx.SaveChangesAsync();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
