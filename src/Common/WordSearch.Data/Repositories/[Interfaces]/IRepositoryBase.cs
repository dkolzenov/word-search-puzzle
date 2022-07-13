namespace WordSearch.Data.Repositories.Interfaces
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();

        Task<bool> AddAsync(TEntity entity);

        Task<bool> UpdateAsync(TEntity entity);

        Task<bool> RemoveAsync(TEntity entity);

        Task<List<TEntity>> QueryAsync(
            params Func<TEntity, bool>[] predicates);
    }
}
