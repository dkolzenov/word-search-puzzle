namespace WordSearch.Services.Word.Factories.Category
{
    using System;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Data.Entities.Word;

    public class CategoryQueryFactory : ICategoryQueryFactory
    {
        public Func<WordEntity, bool> CreateAnimalsQuery()
        {
            var category = CategoryType.Animals.ToString().ToLower();

            return Words => Words.Category == category;
        }

        public Func<WordEntity, bool> CreateVegetablesQuery()
        {
            var category = CategoryType.Vegetables.ToString().ToLower();

            return Words => Words.Category == category;
        }

        public Func<WordEntity, bool> CreateFruitsQuery()
        {
            var category = CategoryType.Fruits.ToString().ToLower();

            return Words => Words.Category == category;
        }
    }
}
