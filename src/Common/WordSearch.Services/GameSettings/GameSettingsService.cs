namespace WordSearch.Services.GameSettings
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.GameSettings;
    using WordSearch.Core.Enums.GameSettings;

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
            DifficultyType difficultyType)
        {
            try
            {
                var result = await _gameSettingsRepository
                    .GetGameSettingsAsync(difficultyType);

                var settings = _mapper.Map<GameSettingsModel>(result);

                return settings;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GameSettingsModel>(
                    ex.InnerException);
            }
        }
    }
}
