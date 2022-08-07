namespace WordSearch.Services.Grid.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Grid.Factories.Interfaces;
    using WordSearch.Data.Entities.Grid;
    using WordSearch.Core.Enums.Grid;
    using WordSearch.Core.Dictionaries.Grid;

    public class GridQueryFactory : IGridQueryFactory
    {
        private readonly SizeToStringMap _sizeMap;

        public GridQueryFactory()
        {
            _sizeMap = new SizeToStringMap();
        }

        public Expression<Func<GridEntity, bool>> CreateSizeQuery(
            SizeType sizeType)
        {
            string size = _sizeMap.GetSizeString(sizeType);

            return Grid => Grid.Size == size;
        }
    }
}
