namespace WordSearch.Services.Direction.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Direction;
    using WordSearch.Services.Direction.Enums;

    public interface IDirectionQueryFactory
    {
        Expression<Func<DirectionEntity, bool>> CreateLayoutQuery(
            LayoutType layoutType);
    }
}
