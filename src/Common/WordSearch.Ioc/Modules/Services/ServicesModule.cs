namespace WordSearch.Ioc.Modules.Services
{
    using Prism.Ioc;
    using Prism.Modularity;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word;
    using WordSearch.Services.Word.Factories;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Services.Word.Factories.Category;
    using WordSearch.Services.Word.Factories.Language;
    using WordSearch.Services.Character;
    using WordSearch.Services.Character.Factories;
    using WordSearch.Services.Character.Factories.Interfaces;
    using WordSearch.Services.Character.Factories.Font;

    public sealed class ServicesModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // WordService
            containerRegistry.RegisterSingleton<
                ICategoryQueryFactory, CategoryQueryFactory>();

            containerRegistry.RegisterSingleton<
                ILanguageQueryFactory, LanguageQueryFactory>();

            containerRegistry.RegisterSingleton<
                IWordQueryFactory, WordQueryFactory>();

            containerRegistry.RegisterSingleton<IWordService, WordService>();

            // CharacterService
            containerRegistry.RegisterSingleton<
                IFontQueryFactory, FontQueryFactory>();

            containerRegistry.RegisterSingleton<
                ICharacterQueryFactory, CharacterQueryFactory>();

            containerRegistry.RegisterSingleton<
                ICharacterService, CharacterService>();
        }
    }
}
