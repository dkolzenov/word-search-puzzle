namespace WordSearch.Services.GameSettings
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.GameSettings.Factories.Interfaces;
    using WordSearch.Services.GameSettings.Enums;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.GameSettings;

    public class GameSettingsService : IGameSettingsService
    {
        private readonly IMapper _mapper;

        private readonly IGameSettingsQueryFactory _gameSettingsFactory;

        private readonly IGameSettingsRepository _gameSettingsRepository;

        public GameSettingsService(
            IMapper mapper,
            IGameSettingsQueryFactory gameSettingsFactory,
            IGameSettingsRepository gameSettingsRepository)
        {
            _mapper = mapper;
            _gameSettingsFactory = gameSettingsFactory;
            _gameSettingsRepository = gameSettingsRepository;
        }

        public async Task<AdvancedGameSettingsModel> GetSettings(
            DifficultyType difficultyType)
        {
            try
            {
                var difficultyQuery = _gameSettingsFactory
                    .CreateDifficultyQuery(difficultyType);

                var result = await _gameSettingsRepository
                    .QueryAsync(difficultyQuery);

                var settings = _mapper.Map<AdvancedGameSettingsModel>(result[0]);

                return settings;
            }
            catch (Exception ex)
            {
                return await Task.FromException<AdvancedGameSettingsModel>(
                    ex.InnerException);
            }
        }
    }
}
