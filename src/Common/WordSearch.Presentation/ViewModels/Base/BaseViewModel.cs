namespace WordSearch.Presentation.ViewModels.Base
{
    using Prism.Mvvm;
    using Prism.Navigation;

    public abstract class BaseViewModel : BindableBase, INavigationAware, IDestructible
    {
        private string _title = null!;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        protected INavigationService NavigationService { get; }

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        // INavigationAware
        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        // INavigationAware
        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        // IDestructible
        public virtual void Destroy()
        {

        }
    }
}
