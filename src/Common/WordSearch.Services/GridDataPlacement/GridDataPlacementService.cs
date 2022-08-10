namespace WordSearch.Services.GridDataPlacement
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Helpers.Interfaces;
    using WordSearch.Models.Word;
    using WordSearch.Models.Grid;
    using WordSearch.Models.GridData;
    using WordSearch.Models.GridDataPlacement;

    public class GridDataPlacementService : IGridDataPlacementService
    {
        private readonly IWordInsertService _wordInsertService;

        private readonly ICharacterInsertService _characterInsertService;

        private readonly IRandomChooserHelper _randomChooserHelper;

        public GridDataPlacementService(
            IWordInsertService wordInsertService,
            ICharacterInsertService characterInsertService,
            IRandomChooserHelper randomChooserHelper)
        {
            _wordInsertService = wordInsertService;
            _characterInsertService = characterInsertService;
            _randomChooserHelper = randomChooserHelper;
        }

        public async Task<GridDataPlacementModel> GetGridDataPlacementAsync(
            GridDataModel gridData)
        {
            try
            {
                List<WordModel> randomWords = _randomChooserHelper
                    .GetRandomUniqueList(gridData.Words, gridData.WordCount);

                GridModel dataGrid = gridData.Grid;

                randomWords.ForEach(async word =>
                    dataGrid = await _wordInsertService
                        .GetWordInsertedGrid(dataGrid, word));

                dataGrid = await _characterInsertService
                    .GetCharacterInsertedGrid(dataGrid, gridData.Characters);

                return new GridDataPlacementModel()
                {
                    DataGrid = dataGrid,
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
