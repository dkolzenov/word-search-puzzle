namespace WordSearch.Ioc.Extensions
{
    using Prism.Ioc;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.Databases;
    using WordSearch.Assets.Settings;

    public static class AssetsRegistryExtension
    {
        public static void RegisterAssetsSingleton(
            this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<
                IWordSearchDbResource, WordSearchDbResource>();

            containerRegistry.RegisterSingleton<IAppSettingsResource, AppSettingsResource>();
        }
    }
}
