namespace WordSearch.Data.Repositories.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Data.Entities.GameSettings;
    using WordSearch.Core.Enums.GameSettings;

    public interface IGameSettingsRepository : IRepositoryBase<GameSettingsEntity>
    {
        Task<GameSettingsEntity> GetGameSettings(DifficultyType difficultyType);
    }
}
