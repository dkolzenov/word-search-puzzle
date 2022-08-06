namespace WordSearch.Services.Character.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Character.Enums;
    using WordSearch.Services.Character.Dictionaries;
    using WordSearch.Services.Character.Factories.Interfaces;
    using WordSearch.Data.Entities.Character;

    public class CharacterQueryFactory : ICharacterQueryFactory
    {
        private readonly ScriptToStringMap _scriptMap;

        public CharacterQueryFactory()
        {
            _scriptMap = new ScriptToStringMap();
        }

        public Expression<Func<CharacterEntity, bool>> CreateScriptQuery(
            ScriptType scriptType)
        {
            string script = _scriptMap.GetScriptString(scriptType);

            return Characters => Characters.Script == script;
        }
    }
}
