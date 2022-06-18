namespace WordSearch.Services.Word.Dictionaries
{
    using System.Collections.Generic;

    using WordSearch.Services.Word.Enums;

    public class LanguageToStringMap
    {
        private readonly Dictionary<LanguageType, string> _map;

        public LanguageToStringMap()
        {
            _map = new Dictionary<LanguageType, string>()
            {
                {LanguageType.Russian, "Русский"},
                {LanguageType.Russian, "Russian"},

                {LanguageType.English, "Английский"},
                {LanguageType.English, "English"}
            };
        }

        public string GetItemString(LanguageType language)
        {
            return _map[language];
        }
    }
}
