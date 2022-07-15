namespace WordSearch.Services.Word.Factories.Language
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Data.Entities.Word;

    public class LanguageQueryFactory : ILanguageQueryFactory
    {
        public Expression<Func<WordEntity, bool>> CreateEnglishQuery()
        {
            var language = LanguageType.English.ToString().ToLower();

            return Words => Words.Language == language;
        }

        public Expression<Func<WordEntity, bool>> CreateRussianQuery()
        {
            var language = LanguageType.Russian.ToString().ToLower();

            return Words => Words.Language == language;
        }
    }
}
