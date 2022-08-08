namespace WordSearch.Data.Repositories.Grid
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.Grid;
    using WordSearch.Data.Contexts.ApplicationDb;
    using WordSearch.Core.Enums.Grid;

    public class GridRepository : RepositoryBase<GridEntity>, IGridRepository
    {
        public GridRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<GridEntity> GetGridAsync(SizeType sizeType)
        {
            try
            {
                string size = sizeType.ToString().ToLower();

                var result = await QueryAsync(grid => grid.Size == size);

                GridEntity grid = result.FirstOrDefault();

                return grid;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GridEntity>(ex.InnerException);
            }
        }
    }
}
