namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Services.GameSettings.Enums;
    using WordSearch.Models.GameSettings;

    public interface IGameSettingsService
    {
        Task<GameSettingsModel> GetSettings(DifficultyType difficultyType);
    }
}
