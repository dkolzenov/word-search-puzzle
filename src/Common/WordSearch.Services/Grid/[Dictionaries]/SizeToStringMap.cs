namespace WordSearch.Services.Grid.Dictionaries
{
    using System.Collections.Generic;

    using WordSearch.Services.Grid.Enums;

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
