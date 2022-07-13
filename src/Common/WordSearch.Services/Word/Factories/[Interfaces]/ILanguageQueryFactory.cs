namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;

    using WordSearch.Data.Entities.Word;

    public interface ILanguageQueryFactory
    {
        Func<WordEntity, bool> CreateEnglishQuery();

        Func<WordEntity, bool> CreateRussianQuery();
    }
}
