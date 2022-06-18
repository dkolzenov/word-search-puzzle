namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;

    using WordSearch.Models.Word;

    public interface ILanguageQueryFactory
    {
        Func<WordModel, bool> CreateEnglishQuery();

        Func<WordModel, bool> CreateRussianQuery();
    }
}
