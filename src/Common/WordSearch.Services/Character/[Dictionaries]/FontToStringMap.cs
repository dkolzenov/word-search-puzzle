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
                {FontType.Cyrillic, "cyrillic"},
                {FontType.Latin, "latin"}
            };
        }

        public string GetFontString(FontType fontType)
        {
            return _map[fontType];
        }
    }
}
