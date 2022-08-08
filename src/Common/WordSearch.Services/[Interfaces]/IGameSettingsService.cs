namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.GameSettings;

    public interface IGameSettingsService
    {
        Task<GameSettingsModel> GetGameSettingsAsync(
            GameSettingsSelectionModel gameSettingsSelection);
    }
}
