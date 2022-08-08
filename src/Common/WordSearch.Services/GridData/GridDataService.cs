namespace WordSearch.Services.GridData
{
    using System;
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.GridData;
    using WordSearch.Models.GameSettings;

    public class GridDataService : IGridDataService
    {
        private readonly IGridService _gridService;

        private readonly IWordService _wordService;

        private readonly ICharacterService _characterService;

        public GridDataService(
            IGridService gridService,
            IWordService wordService,
            ICharacterService characterService)
        {
            _gridService = gridService;
            _wordService = wordService;
            _characterService = characterService;
        }

        public async Task<GridDataModel> GetGridDataAsync(
            GameSettingsModel gameSettings)
        {
            try
            {
                var grid = await _gridService.GetGridAsync(
                    gameSettings.GridSize);

                var words = await _wordService.GetWordsAsync(
                    gameSettings.WordLanguage,
                    gameSettings.WordCategory,
                    gameSettings.MaxWordLength);

                var characters = await _characterService.GetCharactersAsync(
                    gameSettings.WordLanguage);

                var gridData = new GridDataModel()
                {
                    Grid = grid,
                    Words = words,
                    Characters = characters,
                    WordCount = gameSettings.WordCount
                };
                return gridData;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GridDataModel>(
                    ex.InnerException);
            }
        }
    }
}
