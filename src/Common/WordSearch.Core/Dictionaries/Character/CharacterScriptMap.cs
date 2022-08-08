namespace WordSearch.Core.Dictionaries.Character
{
    using System.Collections.Generic;

    using WordSearch.Core.Enums.Word;
    using WordSearch.Core.Enums.Character;

    public class CharacterScriptMap
    {
        private readonly Dictionary<LanguageType, ScriptType> _map;

        public CharacterScriptMap()
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
