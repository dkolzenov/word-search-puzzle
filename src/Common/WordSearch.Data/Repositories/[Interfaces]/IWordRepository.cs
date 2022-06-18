namespace WordSearch.Data.Repositories.Interfaces
{
    using System;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Word;

    public interface IWordRepository : IRepository<WordModel>
    {
        Task<List<WordModel>> QueryWords(
            params Expression<Func<WordModel, bool>>[] predicates);
    }
}
