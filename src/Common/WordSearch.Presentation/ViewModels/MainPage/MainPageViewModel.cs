namespace WordSearch.Presentation.ViewModels.MainPage
{
    using System.Collections.Generic;

    using Prism;
    using Prism.Ioc;
    using Prism.Navigation;
    using Prism.Commands;

    using WordSearch.Presentation.ViewModels.Base;
    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Character.Enums;

    public class MainPageViewModel : BaseViewModel
    {
        private List<string> _words = null!;

        private List<string> _characters = null!;

        private IWordService _wordService = null!;

        private ICharacterService _characterService = null!;

        public List<string> Words
        {
            get => _words;

            set => SetProperty(ref _words, value);
        }

        public List<string> Characters
        {
            get => _characters;

            set => SetProperty(ref _characters, value);
        }

        public DelegateCommand GetAllWordsCommand { get; set; } = null!;

        public DelegateCommand GetAllCharactersCommand { get; set; } = null!;

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            Words = new List<string>();
            Characters = new List<string>();

            InitializeCommand();
            InitializeService();
        }

        private async void GetAllWords()
        {
            Words = await _wordService.GetWords(
                LanguageType.Russian,
                CategoryType.Animals);
        }

        private async void GetAllCharacters()
        {
            Characters = await _characterService.GetCharacters(
                FontType.Latin);
        }

        private void InitializeCommand()
        {
            GetAllWordsCommand = new DelegateCommand(GetAllWords);
            GetAllCharactersCommand = new DelegateCommand(GetAllCharacters);
        }

        private void InitializeService()
        {
            _wordService = PrismApplicationBase.Current.Container
                .Resolve<IWordService>();

            _characterService = PrismApplicationBase.Current.Container
                .Resolve<ICharacterService>();
        }
    }
}
