using Prism.Navigation;
using WordSearch.Presentation.ViewModels.Base;

namespace WordSearch.Presentation.ViewModels.MainPage
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            InitializeCommand();
            InitializeService();
        }
        
        private static void InitializeCommand()
        {
        }

        private static void InitializeService()
        {
        }
    }
}
