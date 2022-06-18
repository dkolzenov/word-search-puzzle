namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Models.Word;

    public interface ILanguageQueryFactory
    {
        Expression<Func<WordModel, bool>> CreateEnglishQuery();

        Expression<Func<WordModel, bool>> CreateRussianQuery();
    }
}
