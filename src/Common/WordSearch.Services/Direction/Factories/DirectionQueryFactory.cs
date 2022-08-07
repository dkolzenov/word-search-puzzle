namespace WordSearch.Services.Direction.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Direction.Factories.Interfaces;
    using WordSearch.Data.Entities.Direction;
    using WordSearch.Core.Enums.Direction;
    using WordSearch.Core.Dictionaries.Direction;

    public class DirectionQueryFactory : IDirectionQueryFactory
    {
        private readonly LayoutToStringMap _layoutMap;

        public DirectionQueryFactory()
        {
            _layoutMap = new LayoutToStringMap();
        }

        public Expression<Func<DirectionEntity, bool>> CreateLayoutQuery(
            LayoutType layoutType)
        {
            string layout = _layoutMap.GetLayoutString(layoutType);

            return Directions => Directions.Layout == layout;
        }
    }
}
