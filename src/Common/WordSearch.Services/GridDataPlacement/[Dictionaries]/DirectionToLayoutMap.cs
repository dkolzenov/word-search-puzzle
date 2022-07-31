namespace WordSearch.Services.GridDataPlacement.Dictionaries
{
    using System.Linq;
    using System.Collections.Generic;

    using WordSearch.Services.GridDataPlacement.Enums;

    public class DirectionToLayoutMap
    {
        private readonly Dictionary<DirectionType, LayoutType> _map;

        private readonly List<DirectionType> _directionList;

        public DirectionToLayoutMap()
        {
            _map = new Dictionary<DirectionType, LayoutType>()
            {
                {DirectionType.TopToBottom,   LayoutType.Vertical},
                {DirectionType.BottomToTop,   LayoutType.Vertical},

                {DirectionType.LeftToRight,   LayoutType.Horizontal},
                {DirectionType.RightToLeft,   LayoutType.Horizontal},

                {DirectionType.LeftToBottom,  LayoutType.Diagonal},
                {DirectionType.RightToBottom, LayoutType.Diagonal},
                {DirectionType.LeftToTop,     LayoutType.Diagonal},
                {DirectionType.RightToTop,    LayoutType.Diagonal}
            };

            _directionList = new List<DirectionType>();
        }

        public List<DirectionType> GetDirectionsByLayout(LayoutType layoutType)
        {
            var directions = _map.Where(x => x.Value == layoutType);

            _directionList.Clear();

            foreach (var direction in directions)
            {
                _directionList.Add(direction.Key);
            }

            return _directionList;
        }
    }
}
