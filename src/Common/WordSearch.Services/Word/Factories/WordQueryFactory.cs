namespace WordSearch.Services.Word.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Data.Entities.Word;

    public class WordQueryFactory : IWordQueryFactory
    {
        public Expression<Func<WordEntity, bool>> CreateCategoryQuery(
            CategoryType categoryType)
        {
            var category = categoryType.ToString().ToLower();

            return Words => Words.Category == category;
        }

        public Expression<Func<WordEntity, bool>> CreateLanguageQuery(
            LanguageType languageType)
        {
            var language = languageType.ToString().ToLower();

            return Words => Words.Language == language;
        }
    }
}
