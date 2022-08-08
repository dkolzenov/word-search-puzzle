namespace WordSearch.Data.Repositories.Direction
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.Direction;
    using WordSearch.Data.Contexts.ApplicationDb;
    using WordSearch.Core.Enums.Direction;

    public class DirectionRepository
        : RepositoryBase<DirectionEntity>, IDirectionRepository
    {
        public DirectionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<DirectionEntity>> GetDirectionsAsync(
            LayoutType layoutType)
        {
            try
            {
                string layout = layoutType.ToString().ToLower();

                var directions = await QueryAsync(
                    direction => direction.Layout == layout);

                return directions;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<DirectionEntity>>(
                    ex.InnerException);
            }
        }
    }
}
