namespace WordSearch.Services.Word.Factories.Category
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Data.Entities.Word;

    public class CategoryQueryFactory : ICategoryQueryFactory
    {
        public Expression<Func<WordEntity, bool>> CreateAnimalsQuery()
        {
            var category = CategoryType.Animals.ToString().ToLower();

            return Words => Words.Category == category;
        }

        public Expression<Func<WordEntity, bool>> CreateVegetablesQuery()
        {
            var category = CategoryType.Vegetables.ToString().ToLower();

            return Words => Words.Category == category;
        }

        public Expression<Func<WordEntity, bool>> CreateFruitsQuery()
        {
            var category = CategoryType.Fruits.ToString().ToLower();

            return Words => Words.Category == category;
        }
    }
}
