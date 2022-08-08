namespace WordSearch.Data.Repositories.GameSettings
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.GameSettings;
    using WordSearch.Data.Contexts.ApplicationDb;
    using WordSearch.Core.Enums.GameSettings;

    public class GameSettingsRepository
        : RepositoryBase<GameSettingsEntity>, IGameSettingsRepository
    {
        public GameSettingsRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public async Task<GameSettingsEntity> GetGameSettingsAsync(
            DifficultyType difficultyType)
        {
            try
            {
                string difficulty = difficultyType.ToString().ToLower();

                var result = await QueryAsync(
                    settings => settings.Difficulty == difficulty);

                GameSettingsEntity gameSettings = result.FirstOrDefault();

                return gameSettings;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GameSettingsEntity>(
                    ex.InnerException);
            }
        }
    }
}
