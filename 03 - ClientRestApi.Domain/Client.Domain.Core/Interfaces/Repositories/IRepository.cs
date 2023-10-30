using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Domain.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
    }
}