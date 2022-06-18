namespace WordSearch.Ioc.Services
{
    using Prism.Ioc;
    using Prism.Modularity;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word;
    using WordSearch.Services.Word.Factories;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Services.Word.Factories.Categories;
    using WordSearch.Services.Word.Factories.Languages;
    using WordSearch.Services.EmbeddedResourceWriter;

    public sealed class ServicesModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IEmbeddedResourceWriterService, EmbeddedResourceWriterService>();
            containerRegistry.RegisterSingleton<ICategoryQueryFactory, CategoryQueryFactory>();
            containerRegistry.RegisterSingleton<ILanguageQueryFactory, LanguageQueryFactory>();
            containerRegistry.RegisterSingleton<IWordQueryFactory, WordQueryFactory>();
            containerRegistry.RegisterSingleton<IWordService, WordService>();
        }
    }
}
