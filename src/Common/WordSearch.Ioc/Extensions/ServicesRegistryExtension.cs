namespace WordSearch.Ioc.Extensions
{
    using Prism.Ioc;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word;
    using WordSearch.Services.Character;
    using WordSearch.Services.Grid;
    using WordSearch.Services.GameSettings;
    using WordSearch.Services.Cell;

    public static class ServicesRegistryExtension
    {
        public static void RegisterServicesSingleton(
            this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IWordService, WordService>();

            containerRegistry.RegisterSingleton<
                ICharacterService, CharacterService>();

            containerRegistry.RegisterSingleton<IGridService, GridService>();

            containerRegistry.RegisterSingleton<
                IGameSettingsService, GameSettingsService>();

            containerRegistry.RegisterSingleton<ICellService, CellService>();
        }
    }
}
