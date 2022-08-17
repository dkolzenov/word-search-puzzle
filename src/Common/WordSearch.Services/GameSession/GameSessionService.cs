namespace WordSearch.Services.GameSession
{
    using System;
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.GameSettings;
    using WordSearch.Models.GameSession;

    public class GameSessionService : IGameSessionService
    {
        private readonly IGridService _gridService;

        private readonly IGridDataService _gridDataService;

        private readonly IDataGridService _dataGridService;

        private readonly IGameSettingsService _gameSettingsService;

        public GameSessionService(
            IGridService gridService,
            IGridDataService gridDataService,
            IDataGridService dataGridService,
            IGameSettingsService gameSettingsService
            )
        {
            _gridService = gridService;
            _gridDataService = gridDataService;
            _dataGridService = dataGridService;
            _gameSettingsService = gameSettingsService;
        }

        public async Task<GameSessionModel> GetGameSessionDataAsync(
            GameSettingsSelectionModel gameSettingsSelection)
        {
            try
            {
                var gameSettings = await _gameSettingsService
                    .GetGameSettingsAsync(gameSettingsSelection);

                var grid = await _gridService
                    .GetGridAsync(gameSettings.GridSize);

                var gridData = await _gridDataService
                    .GetGridDataAsync(gameSettings);

                var dataGrid = await _dataGridService
                    .GetDataGridAsync(grid, gridData);

                var gameSessionData = new GameSessionModel()
                {
                    Id = Guid.NewGuid(),
                    DataGrid = dataGrid,
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
