namespace WordSearch.Presentation.ViewModels.MainPage
{
    using System.Collections.Generic;

    using Prism;
    using Prism.Ioc;
    using Prism.Navigation;
    using Prism.Commands;

    using WordSearch.Presentation.ViewModels.Base;
    using WordSearch.Services.Interfaces;
    using WordSearch.Models.Word;
    using WordSearch.Models.Character;
    using WordSearch.Core.Enums.Word;
    using WordSearch.Core.Enums.Grid;
    using WordSearch.Core.Enums.Character;
    using WordSearch.Core.Enums.GameSettings;

    public class MainPageViewModel : BaseViewModel
    {
        private List<WordModel> _words = null!;

        private List<CharacterModel> _characters = null!;

        private string _gridInfo = null!;

        private string _gameSettingsInfo = null!;

        private IWordService _wordService = null!;

        private ICharacterService _characterService = null!;

        private IGridService _gridService = null!;

        private IGameSettingsService _gameSettingsService = null!;

        public List<WordModel> Words
        {
            get => _words;

            set => SetProperty(ref _words, value);
        }

        public List<CharacterModel> Characters
        {
            get => _characters;

            set => SetProperty(ref _characters, value);
        }

        public string GridInfo
        {
            get => _gridInfo;

            set => SetProperty(ref _gridInfo, value);
        }

        public string GameSettingsInfo
        {
            get => _gameSettingsInfo;

            set => SetProperty(ref _gameSettingsInfo, value);
        }

        public DelegateCommand GetAllWordsCommand { get; set; } = null!;

        public DelegateCommand GetAllCharactersCommand { get; set; } = null!;

        public DelegateCommand GetGridInfoCommand { get; set; } = null!;

        public DelegateCommand GetGameSettingsCommand { get; set; } = null!;

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            Words = new List<WordModel>();
            Characters = new List<CharacterModel>();

            InitializeCommand();
            InitializeService();
        }

        private async void GetAllWords()
        {
            Words = await _wordService.GetWordsAsync(
                LanguageType.Russian,
                CategoryType.Animals);
        }

        private async void GetAllCharacters()
        {
            Characters = await _characterService.GetCharactersAsync(
                LanguageType.Russian);
        }

        private async void GetGridInfo()
        {
            var gridModel = await _gridService.GetGridAsync(SizeType.Medium);

            GridInfo = $"{gridModel.Id} {gridModel.Row} {gridModel.Column} " +
                $"{gridModel.Size}";
        }

        private async void GetGameSettings()
        {
            var settingsModel = await _gameSettingsService
                .GetGameSettingsAsync(DifficultyType.Easy);

            GameSettingsInfo = $"{settingsModel.Difficulty} " +
                $"{settingsModel.GridSize} {settingsModel.WordCount} " +
                $"{settingsModel.MaxWordLength}";
        }

        private void InitializeCommand()
        {
            GetAllWordsCommand = new DelegateCommand(GetAllWords);
            GetAllCharactersCommand = new DelegateCommand(GetAllCharacters);
            GetGridInfoCommand = new DelegateCommand(GetGridInfo);
            GetGameSettingsCommand = new DelegateCommand(GetGameSettings);
        }

        private void InitializeService()
        {
            _wordService = PrismApplicationBase.Current.Container
                .Resolve<IWordService>();

            _characterService = PrismApplicationBase.Current.Container
                .Resolve<ICharacterService>();

            _gridService = PrismApplicationBase.Current.Container
                .Resolve<IGridService>();

            _gameSettingsService = PrismApplicationBase.Current.Container
                .Resolve<IGameSettingsService>();
        }
    }
}
