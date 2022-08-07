namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.GameSession;
    using WordSearch.Models.GameSettings;

    public interface IGameSessionService
    {
        Task<GameSessionModel> GetGameSessionData(
            GameSettingsSelectionModel gameSettingsSelection);
    }
}
