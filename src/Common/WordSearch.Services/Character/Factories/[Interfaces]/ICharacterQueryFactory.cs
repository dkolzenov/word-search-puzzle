namespace WordSearch.Services.Character.Factories.Interfaces
{
    using System;

    using WordSearch.Data.Entities.Character;
    using WordSearch.Services.Character.Enums;

    public interface ICharacterQueryFactory
    {
        Func<CharacterEntity, bool> CreateFontQuery(FontType fontType);
    }
}
