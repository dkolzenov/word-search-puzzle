namespace WordSearch.Services.Grid.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Grid;
    using WordSearch.Services.Grid.Enums;

    public interface IGridQueryFactory
    {
        Expression<Func<GridEntity, bool>> CreateSizeQuery(SizeType sizeType);
    }
}
