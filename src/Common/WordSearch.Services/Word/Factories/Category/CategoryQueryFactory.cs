namespace WordSearch.Services.Word.Factories.Category
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Models.Word;

    public class CategoryQueryFactory : ICategoryQueryFactory
    {
        public Expression<Func<WordModel, bool>> CreateAnimalsQuery()
        {
            var category = CategoryType.Animals.ToString().ToLower();

            return Words => Words.Category == category;
        }

        public Expression<Func<WordModel, bool>> CreateVegetablesQuery()
        {
            var category = CategoryType.Vegetables.ToString().ToLower();

            return Words => Words.Category == category;
        }

        public Expression<Func<WordModel, bool>> CreateFruitsQuery()
        {
            var category = CategoryType.Fruits.ToString().ToLower();

            return Words => Words.Category == category;
        }
    }
}
