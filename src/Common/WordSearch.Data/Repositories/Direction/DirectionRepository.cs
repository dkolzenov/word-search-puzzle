namespace WordSearch.Data.Repositories.Direction
{
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.Direction;
    using WordSearch.Data.Contexts.ApplicationDb;

    public class DirectionRepository
        : RepositoryBase<DirectionEntity>, IDirectionRepository
    {
        public DirectionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
