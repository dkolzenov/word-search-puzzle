namespace WordSearch.Services.GameSession
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.GameSettings;
    using WordSearch.Models.GameSession;
    using WordSearch.Core.Enums.GameSettings;

    public class GameSessionService : IGameSessionService
    {
        private readonly IMapper _mapper;

        private readonly IGameSettingsService _gameSettingsService;

        private readonly IGridDataService _gridDataService;

        public GameSessionService(
            IMapper mapper,
            IGameSettingsService gameSettingsService,
            IGridDataService gridDataService)
        {
            _mapper = mapper;
            _gameSettingsService = gameSettingsService;
            _gridDataService = gridDataService;
        }

        public async Task<GameSessionModel> GetGameSessionData(
            GameSettingsSelectionModel gameSettingsSelection)
        {
            var gameSettingsResult = await _gameSettingsService
                .GetSettings(gameSettingsSelection.Difficulty);

            var gameSettings = _mapper
                .Map(gameSettingsSelection, gameSettingsResult);

            var gridData = await _gridDataService.GetGridData(gameSettings);

            return new GameSessionModel();
        }
    }
}
