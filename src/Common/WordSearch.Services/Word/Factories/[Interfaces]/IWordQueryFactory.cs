namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;

    using WordSearch.Models.Word;
    using WordSearch.Services.Word.Enums;

    public interface IWordQueryFactory
    {
        Func<WordModel, bool> CreateCategoryQuery(CategoryType categoryType);

        Func<WordModel, bool> CreateLanguageQuery(LanguageType languageType);
    }
}
