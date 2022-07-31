namespace WordSearch.Services.GridDataPlacement.Dictionaries
{
    using System.Linq;
    using System.Collections.Generic;

    using WordSearch.Services.GridDataPlacement.Enums;

    public class DirectionToLayoutMap
    {
        private readonly Dictionary<DirectionType, LayoutType> _map;

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
        }

        public List<DirectionType> GetDirectionsByLayout(LayoutType layoutType)
        {
            var directions = _map.Where(x => x.Value == layoutType);

            var directionList = new List<DirectionType>();

            foreach (var direction in directions)
            {
                directionList.Add(direction.Key);
            }

            return directionList;
        }
    }
}
