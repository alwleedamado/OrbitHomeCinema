using OrbitHomeCinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrbitHomeCinema.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
        public Task<IEnumerable<TEntity>> GetPaginatedAsync(int pageNumber, int pageSize);
        public Task<TEntity> GetByIdAsync(Guid id);
        public Task AddAsync(TEntity entity);
        public Task SaveAsync();
        public void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
