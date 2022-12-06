using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Linq.PredicateBuilder;
using Microsoft.EntityFrameworkCore;
using WordSearch.Application.Common.Interfaces;
using WordSearch.Application.Features;
using WordSearch.Domain.Interfaces;

namespace WordSearch.Infrastructure.Services
{
    /// <inheritdoc />
    public abstract class BaseCrudService<TEntity> : IBaseCrudService<TEntity> where TEntity : class, IBaseEntity
    {
        protected readonly IApplicationDbContext DbContext;

        protected readonly IMapper Mapper;

        protected BaseCrudService(IApplicationDbContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<IList<TDto>> GetAllAsync<TDto>(Func<IAndOrOperator<TEntity>, IResult<TEntity>> builder,
            CancellationToken cancellationToken = default,
            BuilderOptions options = BuilderOptions.IgnoreCase | BuilderOptions.IgnoreDefaultInputs | BuilderOptions.Trim)
            where TDto : IDto
        {
            return await DbContext.Set<TEntity>()
                .Build(builder, options)
                .AsNoTracking()
                .ProjectTo<TDto>(Mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }

        /// <inheritdoc />
        public async Task<TDto> GetByIdAsync<TDto>(long id, CancellationToken cancellationToken = default)
            where TDto : IDto
        {
            return Mapper.Map<TDto>(
                await DbContext.Set<TEntity>().AsNoTracking().SingleOrDefaultAsync(x => x.Id == id, cancellationToken)
                ?? throw new Exception($"{nameof(TEntity)} was not found with id = {id}"));
        }

        /// <inheritdoc />
        public async Task<long> CreateAsync<TRequest>(TRequest request, CancellationToken cancellationToken = default)
            where TRequest : ICreateRequest
        {
            var entity = Mapper.Map<TEntity>(request);

            await DbContext.Set<TEntity>().AddAsync(entity, cancellationToken);
            await DbContext.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }

        /// <inheritdoc />
        public async Task UpdateAsync<TRequest>(TRequest request, CancellationToken cancellationToken = default)
            where TRequest : IUpdateRequest
        {
            var entity = await DbContext.Set<TEntity>()
                             .SingleOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                         ?? throw new Exception($"{nameof(TEntity)} was not found with id = {request.Id}");

            Mapper.Map(request, entity);

            await DbContext.SaveChangesAsync(cancellationToken);
        }

        /// <inheritdoc />
        public async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            var entity = await DbContext.Set<TEntity>()
                             .SingleOrDefaultAsync(x => x.Id == id, cancellationToken)
                         ?? throw new Exception($"{nameof(TEntity)} was not found with id = {id}");

            DbContext.Set<TEntity>().Remove(entity);

            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
