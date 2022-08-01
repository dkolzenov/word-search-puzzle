namespace WordSearch.Services.GridDataPlacement.Dictionaries
{
    using System.Linq;
    using System.Collections.Generic;

    using WordSearch.Services.GridDataPlacement.Enums;
    using WordSearch.Services.GridDataPlacement.WordDirection.Interfaces;
    using WordSearch.Services.GridDataPlacement.WordDirection.Diagonal;
    using WordSearch.Services.GridDataPlacement.WordDirection.Horizontal;
    using WordSearch.Services.GridDataPlacement.WordDirection.Vertical;

    public class WordDirectionToLayoutMap
    {
        private static readonly Dictionary<IWordDirection, LayoutType> s_map;

        static WordDirectionToLayoutMap()
        {
            s_map = new Dictionary<IWordDirection, LayoutType>()
            {
                {new TopToBottom(),   LayoutType.Vertical},
                {new BottomToTop(),   LayoutType.Vertical},

                {new LeftToRight(),   LayoutType.Horizontal},
                {new RightToLeft(),   LayoutType.Horizontal},

                {new LeftToBottom(),  LayoutType.Diagonal},
                {new RightToBottom(), LayoutType.Diagonal},
                {new LeftToTop(),     LayoutType.Diagonal},
                {new RightToTop(),    LayoutType.Diagonal}
            };
        }

        public List<IWordDirection> GetWordDirectionListByLayout(
            LayoutType layoutType)
        {
            var wordDirections = s_map.Where(x => x.Value == layoutType);

            var directionList = new List<IWordDirection>();

            foreach (var direction in wordDirections)
            {
                directionList.Add(direction.Key);
            }

            return directionList;
        }
    }
}
