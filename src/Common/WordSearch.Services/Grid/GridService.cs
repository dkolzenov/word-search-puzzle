namespace WordSearch.Services.Grid
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Grid.Factories.Interfaces;
    using WordSearch.Services.Grid.Enums;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Grid;

    public class GridService : IGridService
    {
        private readonly IMapper _mapper;

        private readonly IGridQueryFactory _gridFactory;

        private readonly IGridRepository _gridRepository;

        public GridService(
            IMapper mapper,
            IGridQueryFactory gridFactory,
            IGridRepository gridRepository)
        {
            _mapper = mapper;
            _gridFactory = gridFactory;
            _gridRepository = gridRepository;
        }

        public async Task<GridModel> GetGrid(SizeType sizeType)
        {
            try
            {
                var sizeQuery = _gridFactory.CreateSizeQuery(sizeType);

                var result = await _gridRepository.QueryAsync(sizeQuery);

                var grid = _mapper.Map<GridModel>(result[0]);

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
