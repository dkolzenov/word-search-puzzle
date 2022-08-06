namespace WordSearch.Services.Grid
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Grid.Factories.Interfaces;
    using WordSearch.Services.Grid.Enums;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Grid;
    using WordSearch.Models.Cell;

    public class GridService : IGridService
    {
        private readonly IMapper _mapper;

        private readonly IGridQueryFactory _gridFactory;

        private readonly IGridRepository _gridRepository;

        private readonly ICellService _cellService;

        public GridService(
            IMapper mapper,
            IGridQueryFactory gridFactory,
            IGridRepository gridRepository,
            ICellService cellService)
        {
            _mapper = mapper;
            _gridFactory = gridFactory;
            _gridRepository = gridRepository;
            _cellService = cellService;
        }

        public async Task<GridModel> GetGrid(SizeType sizeType)
        {
            try
            {
                var sizeQuery = _gridFactory.CreateSizeQuery(sizeType);

                var result = await _gridRepository.QueryAsync(sizeQuery);

                var grid = _mapper.Map<GridModel>(result[0]);

                var cells = await _cellService.GetCells(grid.Row, grid.Column);

                PlaceCellsOnGrid(ref grid, cells);

                return grid;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GridModel>(
                    ex.InnerException);
            }
        }

        private void PlaceCellsOnGrid(
            ref GridModel grid,
            List<CellModel> cells)
        {
            for (int i = 0; i < grid.Row; i++)
            {
                for (int j = 0; j < grid.Column; j++)
                {
                    int cellIndex = i * grid.Column + j;

                    grid[i, j] = cells[cellIndex];
                }
            }
        }
    }
}
