﻿namespace WordSearch.Ioc.Extensions
{
    using Prism.Ioc;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Word;
    using WordSearch.Data.Repositories.Character;
    using WordSearch.Data.Repositories.Grid;
    using WordSearch.Data.Repositories.GameSettings;
    using WordSearch.Data.Repositories.Direction;

    public static class DataRegistryExtension
    {
        public static void RegisterRepositoriesSingleton(
            this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<
                IWordRepository, WordRepository>();

            containerRegistry.RegisterSingleton<
                ICharacterRepository, CharacterRepository>();

            containerRegistry.RegisterSingleton<
                IGridRepository, GridRepository>();

            containerRegistry.RegisterSingleton<
                IGameSettingsRepository, GameSettingsRepository>();

            containerRegistry.RegisterSingleton<
                IDirectionRepository, DirectionRepository>();
        }
    }
}
