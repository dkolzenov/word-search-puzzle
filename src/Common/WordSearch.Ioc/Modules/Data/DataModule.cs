namespace WordSearch.Ioc.Modules.Data
{
    using Prism.Ioc;
    using Prism.Modularity;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Word;
    using WordSearch.Data.Repositories.Character;

    public sealed class DataModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<
                IWordRepository, SQLiteWordRepository>();

            containerRegistry.RegisterSingleton<
                ICharacterRepository, SQLiteCharacterRepository>();
        }
    }
}
