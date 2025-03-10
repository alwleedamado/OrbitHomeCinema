using Microsoft.EntityFrameworkCore;
using OrbitHomeCinema.Core.Entities;
using OrbitHomeCinema.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitHomeCinema.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _set;

        protected virtual IQueryable<TEntity> BaseQuery { get; }
        public Repository(DbContext context)
        {
            _context = context;
            _set = context.Set<TEntity>();
            BaseQuery = _set.AsQueryable();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _set.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _set.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await BaseQuery.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _set.FindAsync(id);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            _set.Update(entity);
        }
    }
}
