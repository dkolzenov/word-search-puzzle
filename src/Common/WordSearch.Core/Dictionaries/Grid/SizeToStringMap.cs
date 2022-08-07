namespace WordSearch.Core.Dictionaries.Grid
{
    using System.Collections.Generic;

    using WordSearch.Core.Enums.Grid;

    public class SizeToStringMap
    {
        private readonly Dictionary<SizeType, string> _map;

        public SizeToStringMap()
        {
            _map = new Dictionary<SizeType, string>()
            {
                {SizeType.Small, "small"},
                {SizeType.Medium, "medium"},
                {SizeType.Large, "large"},
            };
        }

        public string GetSizeString(SizeType sizeType)
        {
            return _map[sizeType];
        }
    }
}
