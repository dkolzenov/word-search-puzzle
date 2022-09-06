namespace WordSearch.Data.Repositories.Base
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Contexts.ApplicationDb;

    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class
    {
        private readonly ApplicationDbContext _context;

        protected RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            try
            {
                var entityList = await _context.Set<TEntity>()
                    .AsNoTracking()
                    .ToListAsync();

                return entityList;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<TEntity>>(ex);
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            try
            {
                var result = await _context.Set<TEntity>().AddAsync(entity);

                await _context.SaveChangesAsync();

                return result.Entity;
            }
            catch (Exception ex)
            {
                return await Task.FromException<TEntity>(ex);
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            try
            {
                var result = _context.Set<TEntity>().Update(entity);

                await _context.SaveChangesAsync();

                return result.Entity;
            }
            catch (Exception ex)
            {
                return await Task.FromException<TEntity>(ex);
            }
        }

        public async Task<TEntity> RemoveAsync(TEntity entity)
        {
            try
            {
                var result = _context.Set<TEntity>().Remove(entity);

                await _context.SaveChangesAsync();

                return result.Entity;
            }
            catch (Exception ex)
            {
                return await Task.FromException<TEntity>(ex);
            }
        }

        public async Task<List<TEntity>> QueryAsync(
            params Expression<Func<TEntity, bool>>[] predicates)
        {
            try
            {
                var result = _context.Set<TEntity>().AsQueryable();

                foreach (var predicate in predicates)
                    result = result.Where(predicate);

                return await result.ToListAsync();
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<TEntity>>(ex);
            }
        }
    }
}
