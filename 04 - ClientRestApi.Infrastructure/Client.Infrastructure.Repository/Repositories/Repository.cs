using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Domain.Core.Interfaces.Repositories;
using Client.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Client.Infrastructure.Repository.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly SqlDatabaseContext _context;

        public Repository(SqlDatabaseContext Context)
        {
            _context = Context;
        }

        public async Task Add(TEntity entity)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            try
            {
                return await _context.Set<TEntity>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> GetById(Guid id)
        {
            try
            {
                return await _context.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Update(TEntity entity)
        {
            try
            {
                _context.Entry<TEntity>(entity).State = EntityState.Modified;
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}