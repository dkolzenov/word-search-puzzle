namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Models.Word;
    using WordSearch.Services.Word.Enums;

    public interface IWordQueryFactory
    {
        Expression<Func<WordModel, bool>> CreateCategoryQuery(
            CategoryType categoryType);

        Expression<Func<WordModel, bool>> CreateLanguageQuery(
            LanguageType languageType);
    }
}
