namespace WordSearch.Services.Character.Factories.Interfaces
{
    using System;

    using WordSearch.Data.Entities.Character;

    public interface IFontQueryFactory
    {
        Func<CharacterEntity, bool> CreateCyrillicQuery();

        Func<CharacterEntity, bool> CreateLatinQuery();
    }
}
