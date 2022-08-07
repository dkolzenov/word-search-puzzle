namespace WordSearch.Core.Dictionaries.GridData
{
    using System.Collections.Generic;

    using WordSearch.Core.Enums.Word;
    using WordSearch.Core.Enums.Character;

    public class WordLanguageToCharacterScriptMap
    {
        private readonly Dictionary<LanguageType, ScriptType> _map;

        public WordLanguageToCharacterScriptMap()
        {
            _map = new Dictionary<LanguageType, ScriptType>()
            {
                {LanguageType.Russian, ScriptType.Cyrillic},
                {LanguageType.English, ScriptType.Latin}
            };
        }

        public ScriptType GetScriptType(LanguageType languageType)
        {
            return _map[languageType];
        }
    }
}
