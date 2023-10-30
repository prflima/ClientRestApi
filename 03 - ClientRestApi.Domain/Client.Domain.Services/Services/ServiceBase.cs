using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Domain.Core.Interfaces.Repositories;
using Client.Domain.Core.Interfaces.Services;

namespace Client.Domain.Services.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public ServiceBase(IRepository<TEntity> Repository)
        {
            _repository = Repository;
        }

        public virtual async Task Add(TEntity entity)
        {
            await _repository.Add(entity);
        }

        public virtual async Task Deactivate(Guid id)
        {
            // await _repository.Update(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public virtual async Task Update(TEntity entity)
        {
            await _repository.Update(entity);
        }
    }
}