namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Word;

    public interface ILanguageQueryFactory
    {
        Expression<Func<WordEntity, bool>> CreateEnglishQuery();

        Expression<Func<WordEntity, bool>> CreateRussianQuery();
    }
}
