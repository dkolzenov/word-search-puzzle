namespace WordSearch.Data.Repositories.Grid
{
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.Grid;
    using WordSearch.Data.Contexts.ApplicationDb;

    public class GridRepository : RepositoryBase<GridEntity>, IGridRepository
    {
        public GridRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
