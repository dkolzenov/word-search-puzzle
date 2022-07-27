namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Models.GameSettings;

    public interface IGameSessionService
    {
        Task<bool> StartSession(GameSettingsModel model);

        Task<bool> EndSession();
    }
}
