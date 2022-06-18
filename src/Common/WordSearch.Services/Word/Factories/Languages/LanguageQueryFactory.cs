namespace WordSearch.Services.Word.Factories.Languages
{
    using System;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Models.Word;

    public class LanguageQueryFactory : ILanguageQueryFactory
    {
        public Func<WordModel, bool> CreateEnglishQuery()
        {
            var language = LanguageType.English.ToString().ToLower();

            var languageQuery = new Func<WordModel, bool>(
                word => word.Language == language);

            return languageQuery;
        }

        public Func<WordModel, bool> CreateRussianQuery()
        {
            var language = LanguageType.Russian.ToString().ToLower();

            var languageQuery = new Func<WordModel, bool>(
                word => word.Language == language);

            return languageQuery;
        }
    }
}
