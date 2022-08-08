namespace WordSearch.Services.Direction
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Direction.Factories.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Direction;
    using WordSearch.Core.Enums.Direction;

    public class DirectionService : IDirectionService
    {
        private readonly IMapper _mapper;

        private readonly IDirectionQueryFactory _directionFactory;

        private readonly IDirectionRepository _directionRepository;

        public DirectionService(
            IMapper mapper,
            IDirectionQueryFactory directionFactory,
            IDirectionRepository directionRepository)
        {
            _mapper = mapper;
            _directionFactory = directionFactory;
            _directionRepository = directionRepository;
        }

        public async Task<List<DirectionModel>> GetDirectionsAsync(
            LayoutType layoutType)
        {
            try
            {
                var layoutQuery = _directionFactory
                    .CreateLayoutQuery(layoutType);

                var result = await _directionRepository
                    .QueryAsync(layoutQuery);

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
