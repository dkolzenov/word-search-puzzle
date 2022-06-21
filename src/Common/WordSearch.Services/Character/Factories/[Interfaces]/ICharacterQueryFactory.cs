namespace WordSearch.Services.Character.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Models.Character;
    using WordSearch.Services.Character.Enums;

    public interface ICharacterQueryFactory
    {
        Expression<Func<CharacterModel, bool>> CreateFontQuery(
            FontType fontType);
    }
}
