﻿namespace WordSearch.Core.Dictionaries.Direction
{
    using System.Collections.Generic;

    using WordSearch.Core.Enums.Direction;

    public class LayoutToStringMap
    {
        private readonly Dictionary<LayoutType, string> _map;

        public LayoutToStringMap()
        {
            _map = new Dictionary<LayoutType, string>()
            {
                {LayoutType.Vertical, "vertical"},
                {LayoutType.Horizontal, "horizontal"},
                {LayoutType.Diagonal, "diagonal"}
            };
        }

        public string GetLayoutString(LayoutType layoutType)
        {
            return _map[layoutType];
        }
    }
}