namespace WordSearch.Presentation.ViewModels.MainPage
{
    using System.Collections.Generic;

    using Prism;
    using Prism.Ioc;
    using Prism.Navigation;
    using Prism.Commands;

    using WordSearch.Presentation.ViewModels.Base;
    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Interfaces;

    public class MainPageViewModel : BaseViewModel
    {
        private List<string> _words = null!;

        private readonly IWordService _wordService = null!;

        public List<string> Words
        {
            get => _words;

            set => SetProperty(ref _words, value);
        }

        public DelegateCommand GetAllWordsCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            GetAllWordsCommand = new DelegateCommand(GetAllWords);
        }

        public MainPageViewModel(INavigationService navigationService, IWordService wordService)
            : this(navigationService)
        {
            Words = new List<string>();
            _wordService = PrismApplicationBase.Current.Container.Resolve<IWordService>();
        }

        private async void GetAllWords()
        {
            Words = await _wordService.GetWords(LanguageType.Russian, CategoryType.Animals);
        }
    }
}
