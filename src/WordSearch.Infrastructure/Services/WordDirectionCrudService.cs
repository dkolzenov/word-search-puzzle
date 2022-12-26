using AutoMapper;
using Linq.PredicateBuilder;
using WordSearch.Application.Common.Interfaces;
using WordSearch.Application.Features.WordDirections;
using WordSearch.Application.Features.WordDirections.Dto;
using WordSearch.Application.Features.WordDirections.Requests;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Services
{
    public class WordDirectionCrudService : BaseCrudService<WordDirection>, IWordDirectionCrudService
    {
        public WordDirectionCrudService(IApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IList<WordDirectionDto>> GetWordDirections(GetWordDirectionsRequest request,
            CancellationToken cancellationToken = default)
        {
            return await GetAllAsync<WordDirectionDto>(builder => builder
                    .Equals(x => x.LayoutType, request.LayoutType)
                    .And.Equals(x => x.DirectionType, request.DirectionType),
                cancellationToken);
        }
    }
}