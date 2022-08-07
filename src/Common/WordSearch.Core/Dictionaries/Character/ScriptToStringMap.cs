namespace WordSearch.Core.Dictionaries.Character
{
    using System.Collections.Generic;

    using WordSearch.Core.Enums.Character;

    public class ScriptToStringMap
    {
        private readonly Dictionary<ScriptType, string> _map;

        public ScriptToStringMap()
        {
            _map = new Dictionary<ScriptType, string>()
            {
                {ScriptType.Cyrillic, "cyrillic"},
                {ScriptType.Latin, "latin"}
            };
        }

        public string GetScriptString(ScriptType scriptType)
        {
            return _map[scriptType];
        }
    }
}
