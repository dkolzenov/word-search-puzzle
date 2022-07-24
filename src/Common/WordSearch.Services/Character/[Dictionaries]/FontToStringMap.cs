namespace WordSearch.Services.Character.Dictionaries
{
    using System.Collections.Generic;

    using WordSearch.Services.Character.Enums;

    public class FontToStringMap
    {
        private readonly Dictionary<FontType, string> _map;

        public FontToStringMap()
        {
            _map = new Dictionary<FontType, string>()
            {
                {FontType.Cyrillic, "Кириллица"},
                {FontType.Cyrillic, "Cyrillic"},

                {FontType.Latin, "Латиница"},
                {FontType.Latin, "Latin"}
            };
        }

        public string GetItemString(FontType fontType)
        {
            return _map[fontType];
        }
    }
}
