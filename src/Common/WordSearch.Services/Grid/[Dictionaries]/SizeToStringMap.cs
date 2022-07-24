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
                {SizeType.Small, "Маленький"},
                {SizeType.Small, "Small"},

                {SizeType.Medium, "Средний"},
                {SizeType.Medium, "Medium"},

                {SizeType.Large, "Большой"},
                {SizeType.Large, "Large"},
            };
        }

        public string GetItemString(SizeType sizeType)
        {
            return _map[sizeType];
        }
    }
}
