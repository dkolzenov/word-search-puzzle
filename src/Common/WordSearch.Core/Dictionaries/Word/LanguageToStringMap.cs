namespace WordSearch.Core.Dictionaries.Word
{
    using System.Collections.Generic;

    using WordSearch.Core.Enums.Word;

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

        public string GetLanguageString(LanguageType languageType)
        {
            return _map[languageType];
        }
    }
}
