namespace WordSearch.Data.Repositories.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        Task<List<T>> Get();

        Task<bool> Add(T model);

        Task<bool> Update(T model);

        Task<bool> Remove(T model);
    }
}
