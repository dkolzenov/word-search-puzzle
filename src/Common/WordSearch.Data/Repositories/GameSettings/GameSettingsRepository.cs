namespace WordSearch.Data.Repositories.GameSettings
{
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.GameSettings;
    using WordSearch.Data.Contexts.ApplicationDb;

    public class GameSettingsRepository
        : RepositoryBase<GameSettingsEntity>, IGameSettingsRepository
    {
        public GameSettingsRepository(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
