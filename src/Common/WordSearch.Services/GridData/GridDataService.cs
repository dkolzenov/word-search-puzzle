namespace WordSearch.Services.GridData
{
    using System;
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.GridData;
    using WordSearch.Models.GameSettings;

    public class GridDataService : IGridDataService
    {
        private readonly IWordService _wordService;

        private readonly ICharacterService _characterService;

        public GridDataService(
            IWordService wordService,
            ICharacterService characterService)
        {
            _wordService = wordService;
            _characterService = characterService;
        }

        public async Task<GridDataModel> GetGridDataAsync(
            GameSettingsModel gameSettings)
        {
            try
            {
                var words = await _wordService.GetWordsAsync(
                    gameSettings.WordLanguage,
                    gameSettings.WordCategory,
                    gameSettings.MaxWordLength);

                var characters = await _characterService.GetCharactersAsync(
                    gameSettings.WordLanguage);

                var gridData = new GridDataModel()
                {
                    Words = words,
                    Characters = characters
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
