namespace WordSearch.Services.Grid.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Grid.Enums;
    using WordSearch.Services.Grid.Factories.Interfaces;
    using WordSearch.Data.Entities.Grid;

    public class GridQueryFactory : IGridQueryFactory
    {
        public Expression<Func<GridEntity, bool>> CreateSizeQuery(
            SizeType sizeType)
        {
            var size = sizeType.ToString().ToLower();

            return Grid => Grid.Size == size;
        }
    }
}
