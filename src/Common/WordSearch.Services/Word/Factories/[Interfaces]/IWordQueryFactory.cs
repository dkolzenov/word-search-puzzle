namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;

    using WordSearch.Data.Entities.Word;
    using WordSearch.Services.Word.Enums;

    public interface IWordQueryFactory
    {
        Func<WordEntity, bool> CreateCategoryQuery(CategoryType categoryType);

        Func<WordEntity, bool> CreateLanguageQuery(LanguageType languageType);
    }
}
