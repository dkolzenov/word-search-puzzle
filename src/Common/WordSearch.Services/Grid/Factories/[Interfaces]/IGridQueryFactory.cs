namespace WordSearch.Services.Grid.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Grid;
    using WordSearch.Core.Enums.Grid;

    public interface IGridQueryFactory
    {
        Expression<Func<GridEntity, bool>> CreateSizeQuery(SizeType sizeType);
    }
}
