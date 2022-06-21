namespace WordSearch.Services.Character.Factories.Font
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Character.Enums;
    using WordSearch.Services.Character.Factories.Interfaces;
    using WordSearch.Models.Character;

    public class FontQueryFactory : IFontQueryFactory
    {
        public Expression<Func<CharacterModel, bool>> CreateCyrillicQuery()
        {
            var font = FontType.Cyrillic.ToString().ToLower();

            return Characters => Characters.Font == font;
        }

        public Expression<Func<CharacterModel, bool>> CreateLatinQuery()
        {
            var font = FontType.Latin.ToString().ToLower();

            return Characters => Characters.Font == font;
        }
    }
}
