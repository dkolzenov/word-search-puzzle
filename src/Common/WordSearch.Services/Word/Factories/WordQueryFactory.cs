namespace WordSearch.Services.Word.Factories
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Models.Word;

    public class WordQueryFactory : IWordQueryFactory
    {
        private readonly ICategoryQueryFactory _categoryQueryFactory;

        private readonly ILanguageQueryFactory _languageQueryFactory;

        public WordQueryFactory(
            ICategoryQueryFactory categoryQueryFactory,
            ILanguageQueryFactory languageQueryFactory)
        {
            _categoryQueryFactory = categoryQueryFactory;
            _languageQueryFactory = languageQueryFactory;
        }

        public Expression<Func<WordModel, bool>> CreateCategoryQuery(
            CategoryType categoryType)
        {
            switch (categoryType)
            {
                case CategoryType.Animals:
                    return _categoryQueryFactory.CreateAnimalsQuery();

                case CategoryType.Vegetables:
                    return _categoryQueryFactory.CreateVegetablesQuery();

                case CategoryType.Fruits:
                    return _categoryQueryFactory.CreateFruitsQuery();

                default:
                    throw new ArgumentNullException();
            }
        }

        public Expression<Func<WordModel, bool>> CreateLanguageQuery(
            LanguageType languageType)
        {
            switch (languageType)
            {
                case LanguageType.English:
                    return _languageQueryFactory.CreateEnglishQuery();

                case LanguageType.Russian:
                    return _languageQueryFactory.CreateRussianQuery();

                default:
                    throw new ArgumentNullException();
            }
        }
    }
}
