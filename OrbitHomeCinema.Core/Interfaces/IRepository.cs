using OrbitHomeCinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitHomeCinema.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<TEntity> GetByIdAsync(Guid id);
        public Task AddAsync(TEntity entity);
        public Task SaveAsync();
        public void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
