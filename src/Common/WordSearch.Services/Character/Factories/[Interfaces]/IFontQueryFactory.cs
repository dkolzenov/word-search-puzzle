namespace WordSearch.Services.Character.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Character;

    public interface IFontQueryFactory
    {
        Expression<Func<CharacterEntity, bool>> CreateCyrillicQuery();

        Expression<Func<CharacterEntity, bool>> CreateLatinQuery();
    }
}
