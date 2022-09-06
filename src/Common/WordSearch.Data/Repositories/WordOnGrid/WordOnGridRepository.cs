namespace WordSearch.Data.Repositories.WordOnGrid
{
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.WordOnGrid;
    using WordSearch.Data.Contexts.ApplicationDb;

    public class WordOnGridRepository
        : RepositoryBase<WordOnGridEntity>, IWordOnGridRepository
    {
        public WordOnGridRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
