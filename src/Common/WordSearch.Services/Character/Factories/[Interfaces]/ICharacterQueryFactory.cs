namespace WordSearch.Services.Character.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Character;
    using WordSearch.Services.Character.Enums;

    public interface ICharacterQueryFactory
    {
        Expression<Func<CharacterEntity, bool>> CreateScriptQuery(
            ScriptType scriptType);
    }
}
