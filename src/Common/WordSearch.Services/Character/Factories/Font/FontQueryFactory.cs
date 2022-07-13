namespace WordSearch.Services.Character.Factories.Font
{
    using System;

    using WordSearch.Services.Character.Enums;
    using WordSearch.Services.Character.Factories.Interfaces;
    using WordSearch.Data.Entities.Character;

    public class FontQueryFactory : IFontQueryFactory
    {
        public Func<CharacterEntity, bool> CreateCyrillicQuery()
        {
            var font = FontType.Cyrillic.ToString().ToLower();

            return Characters => Characters.Font == font;
        }

        public Func<CharacterEntity, bool> CreateLatinQuery()
        {
            var font = FontType.Latin.ToString().ToLower();

            return Characters => Characters.Font == font;
        }
    }
}
