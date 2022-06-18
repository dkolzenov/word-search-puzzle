namespace WordSearch.Ioc.Presentation
{
    using Prism.Ioc;
    using Prism.Modularity;

    using WordSearch.Presentation.ViewModels.MainPage;
    using WordSearch.Presentation.Views.MainPage;

    public sealed class PresentationModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPageView, MainPageViewModel>();
        }
    }
}
