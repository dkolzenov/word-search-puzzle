namespace WordSearch.Services.Direction
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Direction;
    using WordSearch.Core.Enums.Direction;

    public class DirectionService : IDirectionService
    {
        private readonly IMapper _mapper;

        private readonly IDirectionRepository _directionRepository;

        public DirectionService(
            IMapper mapper,
            IDirectionRepository directionRepository)
        {
            _mapper = mapper;
            _directionRepository = directionRepository;
        }

        public async Task<List<DirectionModel>> GetDirectionsAsync(
            LayoutType layoutType)
        {
            try
            {
                var result = await _directionRepository
                    .GetDirectionsAsync(layoutType);

                var directions = _mapper.Map<List<DirectionModel>>(result);

                return directions;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<DirectionModel>>(
                    ex.InnerException);
            }
        }
    }
}
