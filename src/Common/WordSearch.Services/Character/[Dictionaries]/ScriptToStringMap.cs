namespace WordSearch.Services.Character.Dictionaries
{
    using System.Collections.Generic;

    using WordSearch.Services.Character.Enums;

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
