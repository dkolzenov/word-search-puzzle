namespace WordSearch.Services.Grid.Factories.Size
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Grid.Enums;
    using WordSearch.Services.Grid.Factories.Interfaces;
    using WordSearch.Data.Entities.Grid;

    public class SizeQueryFactory : ISizeQueryFactory
    {
        public Expression<Func<GridEntity, bool>> CreateSmallQuery()
        {
            var size = SizeType.Small.ToString().ToLower();

            return Grid => Grid.Size == size;
        }

        public Expression<Func<GridEntity, bool>> CreateMediumQuery()
        {
            var size = SizeType.Medium.ToString().ToLower();

            return Grid => Grid.Size == size;
        }

        public Expression<Func<GridEntity, bool>> CreateLargeQuery()
        {
            var size = SizeType.Large.ToString().ToLower();

            return Grid => Grid.Size == size;
        }
    }
}
