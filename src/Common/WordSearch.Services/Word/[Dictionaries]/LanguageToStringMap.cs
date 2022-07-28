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
                {LanguageType.Russian, "russian"},
                {LanguageType.English, "english"}
            };
        }

        public string GetItemString(LanguageType languageType)
        {
            return _map[languageType];
        }
    }
}
