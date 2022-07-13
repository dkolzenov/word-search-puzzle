namespace WordSearch.Ioc.Extensions
{
    using Prism.Ioc;

    using WordSearch.Presentation.ViewModels.MainPage;
    using WordSearch.Presentation.Views.MainPage;

    public static class PresentationRegistryExtension
    {
        public static void RegisterPresentationSingleton(
            this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<
                MainPageView, MainPageViewModel>();
        }
    }
}
