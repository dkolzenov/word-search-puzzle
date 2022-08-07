namespace WordSearch.Services.GameSettings.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.GameSettings;
    using WordSearch.Core.Enums.GameSettings;

    public interface IGameSettingsQueryFactory
    {
        Expression<Func<GameSettingsEntity, bool>> CreateDifficultyQuery(
            DifficultyType difficultyType);
    }
}
