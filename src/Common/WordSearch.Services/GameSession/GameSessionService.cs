namespace WordSearch.Services.GameSession
{
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.GameSettings;

    public class GameSessionService : IGameSessionService
    {
        public GameSessionService()
        {
        }

        public Task<bool> StartSession(GameSettingsModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> EndSession()
        {
            throw new System.NotImplementedException();
        }
    }
}
