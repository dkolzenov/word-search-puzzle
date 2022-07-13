namespace WordSearch.Data.Repositories.Word
{
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.Word;
    using WordSearch.Data.Contexts.ApplicationDb;

    public class WordRepository : RepositoryBase<WordEntity>, IWordRepository
    {
        public WordRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
