namespace WordSearch.Services.GridData
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.GridData;
    using WordSearch.Models.GameSettings;
    using WordSearch.Models.Word;
    using WordSearch.Models.Character;
    using WordSearch.Core.Enums.Character;
    using WordSearch.Core.Dictionaries.GridData;

    public class GridDataService : IGridDataService
    {
        private readonly WordLanguageToCharacterScriptMap _languageToScriptMap;

        private readonly ICharacterService _characterService;

        private readonly IWordService _wordService;

        public GridDataService(
            ICharacterService characterService,
            IWordService wordService)
        {
            _languageToScriptMap = new WordLanguageToCharacterScriptMap();
            _characterService = characterService;
            _wordService = wordService;
        }

        public async Task<GridDataModel> GetGridDataAsync(
            GameSettingsModel gameSettings)
        {
            List<WordModel> words = await GetWords(gameSettings);
            List<CharacterModel> characters = await GetCharacters(gameSettings);

            var gridData = new GridDataModel()
            {
                Words = words,
                Characters = characters
            };
            return gridData;
        }

        private async Task<List<WordModel>> GetWords(
            GameSettingsModel gameSettings)
        {
            List<WordModel> words = await _wordService.GetWords(
                gameSettings.WordLanguage,
                gameSettings.WordCategory,
                gameSettings.MaxWordLength);

            return words;
        }

        private async Task<List<CharacterModel>> GetCharacters(
            GameSettingsModel gameSettings)
        {
            ScriptType script = _languageToScriptMap
                .GetScriptType(gameSettings.WordLanguage);

            List<CharacterModel> characters = await _characterService
                .GetCharactersAsync(script);

            return characters;
        }
    }
}
