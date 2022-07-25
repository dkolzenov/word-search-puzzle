namespace WordSearch.Services.Grid
{
    using System;
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Grid.Factories.Interfaces;
    using WordSearch.Services.Grid.Enums;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Entities.Grid;

    public class GridService : IGridService
    {
        private readonly IGridQueryFactory _gridFactory;

        private readonly IGridRepository _gridRepository;

        public GridService(
            IGridQueryFactory gridFactory,
            IGridRepository gridRepository)
        {
            _gridFactory = gridFactory;
            _gridRepository = gridRepository;
        }

        public async Task<GridEntity> GetGrid(SizeType sizeType)
        {
            try
            {
                var sizeQuery = _gridFactory.CreateSizeQuery(sizeType);

                var result = await _gridRepository.QueryAsync(sizeQuery);

                var grid = result.GetEnumerator().Current;

                return grid;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GridEntity>(
                    ex.InnerException);
            }
        }
    }
}
