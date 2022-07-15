namespace WordSearch.Services.Character.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Character;
    using WordSearch.Services.Character.Enums;
    using WordSearch.Services.Character.Factories.Interfaces;

    public class CharacterQueryFactory : ICharacterQueryFactory
    {
        private readonly IFontQueryFactory _fontQueryFactory;

        public CharacterQueryFactory(IFontQueryFactory fontQueryFactory)
        {
            _fontQueryFactory = fontQueryFactory;
        }

        public Expression<Func<CharacterEntity, bool>> CreateFontQuery(
            FontType fontType)
        {
            switch (fontType)
            {
                case FontType.Cyrillic:
                    return _fontQueryFactory.CreateCyrillicQuery();

                case FontType.Latin:
                    return _fontQueryFactory.CreateLatinQuery();

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
