namespace WordSearch.Services.GameSettings
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.GameSettings;

    public class GameSettingsService : IGameSettingsService
    {
        private readonly IMapper _mapper;

        private readonly IGameSettingsRepository _gameSettingsRepository;

        public GameSettingsService(
            IMapper mapper,
            IGameSettingsRepository gameSettingsRepository)
        {
            _mapper = mapper;
            _gameSettingsRepository = gameSettingsRepository;
        }

        public async Task<GameSettingsModel> GetGameSettingsAsync(
            GameSettingsSelectionModel gameSettingsSelection)
        {
            try
            {
                var result = await _gameSettingsRepository
                    .GetGameSettingsAsync(gameSettingsSelection.Difficulty);

                var gameSettings = _mapper.Map<GameSettingsModel>(result);

                gameSettings = _mapper.Map(gameSettingsSelection, gameSettings);

                return gameSettings;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GameSettingsModel>(
                    ex.InnerException);
            }
        }
    }
}
