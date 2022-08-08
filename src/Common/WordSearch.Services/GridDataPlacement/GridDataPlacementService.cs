namespace WordSearch.Services.GridDataPlacement
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Helpers.Interfaces;
    using WordSearch.Models.GridData;
    using WordSearch.Models.GridDataPlacement;

    public class GridDataPlacementService : IGridDataPlacementService
    {
        private readonly IMapper _mapper;

        private readonly IDirectionService _directionService;

        private readonly IRandomChooserHelper _randomChooserHelper;

        public GridDataPlacementService(
            IMapper mapper,
            IDirectionService directionService,
            IRandomChooserHelper randomChooserHelper)
        {
            _mapper = mapper;
            _directionService = directionService;
            _randomChooserHelper = randomChooserHelper;
        }

        public async Task<GridDataPlacementModel> GetGridDataPlacementAsync(
            GridDataModel gridData)
        {
            try
            {
                var cells = gridData.Grid.Cells;

                var randomWords = _randomChooserHelper
                    .GetRandomUniqueList(gridData.Words, gridData.WordCount);

                // TODO: temp plug
                return new GridDataPlacementModel()
                {
                    Grid = gridData.Grid,
                    RandomWords = randomWords
                };
            }
            catch (Exception ex)
            {
                return await Task.FromException<GridDataPlacementModel>(
                    ex.InnerException);
            }
        }
    }
}
