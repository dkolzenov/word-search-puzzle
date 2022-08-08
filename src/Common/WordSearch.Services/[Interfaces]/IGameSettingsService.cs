namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.GameSettings;
    using WordSearch.Core.Enums.GameSettings;

    public interface IGameSettingsService
    {
        Task<GameSettingsModel> GetGameSettingsAsync(
            DifficultyType difficultyType);
    }
}
