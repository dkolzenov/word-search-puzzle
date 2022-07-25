namespace WordSearch.Services.Character.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Character;
    using WordSearch.Services.Character.Enums;
    using WordSearch.Services.Character.Factories.Interfaces;

    public class CharacterQueryFactory : ICharacterQueryFactory
    {
        public Expression<Func<CharacterEntity, bool>> CreateFontQuery(
            FontType fontType)
        {
            var font = fontType.ToString().ToLower();

            return Characters => Characters.Font == font;
        }
    }
}
