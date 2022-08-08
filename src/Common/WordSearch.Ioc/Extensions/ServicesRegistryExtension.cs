﻿namespace WordSearch.Ioc.Extensions
{
    using Prism.Ioc;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word;
    using WordSearch.Services.Word.Factories;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Services.Character;
    using WordSearch.Services.Grid;
    using WordSearch.Services.Grid.Factories;
    using WordSearch.Services.Grid.Factories.Interfaces;
    using WordSearch.Services.GameSettings;
    using WordSearch.Services.Cell;

    public static class ServicesRegistryExtension
    {
        public static void RegisterServicesSingleton(
            this IContainerRegistry containerRegistry)
        {
            // WordService
            containerRegistry.RegisterSingleton<
                IWordQueryFactory, WordQueryFactory>();

            containerRegistry.RegisterSingleton<IWordService, WordService>();

            // CharacterService
            containerRegistry.RegisterSingleton<
                ICharacterService, CharacterService>();

            // GridService
            containerRegistry.RegisterSingleton<
                IGridQueryFactory, GridQueryFactory>();

            containerRegistry.RegisterSingleton<IGridService, GridService>();

            // GameSettingsService
            containerRegistry.RegisterSingleton<
                IGameSettingsService, GameSettingsService>();

            // CellService
            containerRegistry.RegisterSingleton<ICellService, CellService>();
        }
    }
}
