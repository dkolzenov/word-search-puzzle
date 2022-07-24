namespace WordSearch.Services.Grid.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Grid.Enums;
    using WordSearch.Services.Grid.Factories.Interfaces;
    using WordSearch.Data.Entities.Grid;

    public class GridQueryFactory : IGridQueryFactory
    {
        private readonly ISizeQueryFactory _sizeQueryFactory;

        public GridQueryFactory(ISizeQueryFactory sizeQueryFactory)
        {
            _sizeQueryFactory = sizeQueryFactory;
        }

        public Expression<Func<GridEntity, bool>> CreateSizeQuery(
            SizeType sizeType)
        {
            switch (sizeType)
            {
                case SizeType.Small:
                    return _sizeQueryFactory.CreateSmallQuery();

                case SizeType.Medium:
                    return _sizeQueryFactory.CreateMediumQuery();

                case SizeType.Large:
                    return _sizeQueryFactory.CreateLargeQuery();

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
