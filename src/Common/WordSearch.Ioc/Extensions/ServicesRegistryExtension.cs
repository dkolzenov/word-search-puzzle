﻿namespace WordSearch.Ioc.Extensions
{
    using Prism.Ioc;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word;
    using WordSearch.Services.Word.Factories;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Services.Character;
    using WordSearch.Services.Character.Factories;
    using WordSearch.Services.Character.Factories.Interfaces;
    using WordSearch.Services.Grid;
    using WordSearch.Services.Grid.Factories;
    using WordSearch.Services.Grid.Factories.Interfaces;
    using WordSearch.Services.GameSettings;
    using WordSearch.Services.GameSettings.Factories;
    using WordSearch.Services.GameSettings.Factories.Interfaces;
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
                ICharacterQueryFactory, CharacterQueryFactory>();

            containerRegistry.RegisterSingleton<
                ICharacterService, CharacterService>();

            // GridService
            containerRegistry.RegisterSingleton<
                IGridQueryFactory, GridQueryFactory>();

            containerRegistry.RegisterSingleton<IGridService, GridService>();

            // GameSettingsService
            containerRegistry.RegisterSingleton<
                IGameSettingsQueryFactory, GameSettingsQueryFactory>();

            containerRegistry.RegisterSingleton<
                IGameSettingsService, GameSettingsService>();

            // CellService
            containerRegistry.RegisterSingleton<ICellService, CellService>();
        }
    }
}
