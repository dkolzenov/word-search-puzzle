namespace WordSearch.Services.GameSession
{
    using System;
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.GameSettings;
    using WordSearch.Models.GameSession;

    public class GameSessionService : IGameSessionService
    {
        private readonly IGameSettingsService _gameSettingsService;

        private readonly IGridDataService _gridDataService;

        public GameSessionService(
            IGameSettingsService gameSettingsService,
            IGridDataService gridDataService)
        {
            _gameSettingsService = gameSettingsService;
            _gridDataService = gridDataService;
        }

        public async Task<GameSessionModel> GetGameSessionDataAsync(
            GameSettingsSelectionModel gameSettingsSelection)
        {
            try
            {
                var gameSettings = await _gameSettingsService
                    .GetGameSettingsAsync(gameSettingsSelection);

                var gridData = await _gridDataService
                    .GetGridDataAsync(gameSettings);

                return new GameSessionModel();
            }
            catch (Exception ex)
            {
                return await Task.FromException<GameSessionModel>(
                    ex.InnerException);
            }
        }
    }
}
