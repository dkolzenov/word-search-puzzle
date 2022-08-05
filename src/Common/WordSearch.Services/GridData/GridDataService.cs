namespace WordSearch.Services.GridData
{
    using System;
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word.Enums;
    using WordSearch.Models.DataGrid;
    using WordSearch.Models.GameSettings;

    public class GridDataService : IGridDataService
    {
        private readonly ICharacterService _characterService;

        private readonly IWordService _wordService;

        public GridDataService(
            ICharacterService characterService,
            IWordService wordService)
        {
            _characterService = characterService;
            _wordService = wordService;
        }

        public async Task<GridDataModel> GetGridData(
            GameSettingsModel gameSettings)
        {
            var wordLanguage = Enum.Parse<LanguageType>(
                gameSettings.WordLanguage,
                ignoreCase: true);

            var wordCategory = Enum.Parse<CategoryType>(
                gameSettings.WordCategory,
                ignoreCase: true);

            var words = await _wordService.GetWords(wordLanguage, wordCategory);

            throw new NotImplementedException();
        }
    }
}
