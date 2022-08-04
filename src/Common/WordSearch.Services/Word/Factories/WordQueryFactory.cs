namespace WordSearch.Services.Word.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Word.Dictionaries;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Data.Entities.Word;

    public class WordQueryFactory : IWordQueryFactory
    {
        private readonly CategoryToStringMap _categoryMap;

        private readonly LanguageToStringMap _languageMap;

        public WordQueryFactory()
        {
            _categoryMap = new CategoryToStringMap();
            _languageMap = new LanguageToStringMap();
        }

        public Expression<Func<WordEntity, bool>> CreateCategoryQuery(
            CategoryType categoryType)
        {
            string category = _categoryMap.GetCategoryString(categoryType);

            return Words => Words.Category == category;
        }

        public Expression<Func<WordEntity, bool>> CreateLanguageQuery(
            LanguageType languageType)
        {
            string language = _languageMap.GetLanguageString(languageType);

            return Words => Words.Language == language;
        }

        public Expression<Func<WordEntity, bool>> CreateMaxLengthQuery(
            int maxLength)
        {
            return Words => Words.Value.Length <= maxLength;
        }
    }
}
