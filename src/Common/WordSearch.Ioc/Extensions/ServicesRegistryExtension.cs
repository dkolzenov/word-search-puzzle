namespace WordSearch.Ioc.Extensions
{
    using Prism.Ioc;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word;
    using WordSearch.Services.Character;
    using WordSearch.Services.Grid;
    using WordSearch.Services.GameSettings;
    using WordSearch.Services.Cell;
    using WordSearch.Services.GridData;
    using WordSearch.Services.Direction;

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

            containerRegistry.RegisterSingleton<
                IGridDataService, GridDataService>();

            containerRegistry.RegisterSingleton<
                IDirectionService, DirectionService>();
        }
    }
}
