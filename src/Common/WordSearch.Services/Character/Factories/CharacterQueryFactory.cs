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
        private readonly FontToStringMap _fontMap;

        public CharacterQueryFactory()
        {
            _fontMap = new FontToStringMap();
        }

        public Expression<Func<CharacterEntity, bool>> CreateFontQuery(
            FontType fontType)
        {
            string font = _fontMap.GetFontString(fontType);

            return Characters => Characters.Font == font;
        }
    }
}
