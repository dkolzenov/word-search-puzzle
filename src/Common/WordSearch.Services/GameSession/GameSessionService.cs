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

        private readonly IGridDataPlacementService _gridDataPlacementService;

        public GameSessionService(
            IGameSettingsService gameSettingsService,
            IGridDataService gridDataService,
            IGridDataPlacementService gridDataPlacementService)
        {
            _gameSettingsService = gameSettingsService;
            _gridDataService = gridDataService;
            _gridDataPlacementService = gridDataPlacementService;
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

                var gridDataPlacement = await _gridDataPlacementService
                    .GetGridDataPlacementAsync(gridData);

                var gameSessionData = new GameSessionModel()
                {
                    Id = Guid.NewGuid(),
                    Grid = gridDataPlacement.Grid,
                    Words = gridDataPlacement.RandomWords,
                    WordCategory = gameSettings.WordCategory
                };
                return gameSessionData;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GameSessionModel>(
                    ex.InnerException);
            }
        }
    }
}
