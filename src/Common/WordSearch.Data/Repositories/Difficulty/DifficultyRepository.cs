namespace WordSearch.Data.Repositories.Difficulty
{
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.Difficulty;
    using WordSearch.Data.Contexts.ApplicationDb;

    public class DifficultyRepository
        : RepositoryBase<DifficultyEntity>, IDifficultyRepository
    {
        public DifficultyRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
