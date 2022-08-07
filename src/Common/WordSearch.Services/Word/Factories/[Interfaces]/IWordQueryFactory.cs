namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Word;
    using WordSearch.Core.Enums.Word;

    public interface IWordQueryFactory
    {
        Expression<Func<WordEntity, bool>> CreateCategoryQuery(
            CategoryType categoryType);

        Expression<Func<WordEntity, bool>> CreateLanguageQuery(
            LanguageType languageType);
    }
}
