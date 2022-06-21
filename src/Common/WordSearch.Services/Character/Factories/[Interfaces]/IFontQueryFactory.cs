namespace WordSearch.Services.Character.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Models.Character;

    public interface IFontQueryFactory
    {
        Expression<Func<CharacterModel, bool>> CreateCyrillicQuery();

        Expression<Func<CharacterModel, bool>> CreateLatinQuery();
    }
}
