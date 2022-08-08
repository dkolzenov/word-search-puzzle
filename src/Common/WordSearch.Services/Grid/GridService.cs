namespace WordSearch.Services.Grid
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Grid;
    using WordSearch.Core.Enums.Grid;

    public class GridService : IGridService
    {
        private readonly IMapper _mapper;

        private readonly IGridRepository _gridRepository;

        private readonly ICellService _cellService;

        public GridService(
            IMapper mapper,
            IGridRepository gridRepository,
            ICellService cellService)
        {
            _mapper = mapper;
            _gridRepository = gridRepository;
            _cellService = cellService;
        }

        public async Task<GridModel> GetGridAsync(SizeType sizeType)
        {
            try
            {
                var result = await _gridRepository.GetGridAsync(sizeType);

                var grid = _mapper.Map<GridModel>(result);

                grid.Cells = await _cellService
                    .GetCellsAsync(grid.Row, grid.Column);

                return grid;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GridModel>(
                    ex.InnerException);
            }
        }
    }
}
