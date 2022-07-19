namespace WordSearch.Ioc.Extensions
{
    using System.Reflection;

    using Prism.Ioc;

    using WordSearch.Assets.Interfaces;
    using WordSearch.Assets.Databases;
    using WordSearch.Assets.Settings;
    using WordSearch.Assets.Properties;

    public static class AssetsRegistryExtension
    {
        public static void RegisterAssetsSingleton(
            this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<Assembly>(
                _ => AssetProperties.Assembly);

            containerRegistry.RegisterSingleton<
                IWordSearchDatabase, WordSearchDatabase>();

            containerRegistry.RegisterSingleton<IAppSettings, AppSettings>();
        }
    }
}
