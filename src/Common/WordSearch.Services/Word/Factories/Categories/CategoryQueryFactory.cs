namespace WordSearch.Services.Word.Factories.Categories
{
    using System;

    using WordSearch.Services.Word.Enums;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Models.Word;

    public class CategoryQueryFactory : ICategoryQueryFactory
    {
        public Func<WordModel, bool> CreateAnimalsQuery()
        {
            var category = CategoryType.Animals.ToString().ToLower();

            var categoryQuery = new Func<WordModel, bool>(
                word => word.Category == category);

            return categoryQuery;
        }

        public Func<WordModel, bool> CreateVegetablesQuery()
        {
            var category = CategoryType.Vegetables.ToString().ToLower();

            var categoryQuery = new Func<WordModel, bool>(
                word => word.Category == category);

            return categoryQuery;
        }

        public Func<WordModel, bool> CreateFruitsQuery()
        {
            var category = CategoryType.Fruits.ToString().ToLower();

            var categoryQuery = new Func<WordModel, bool>(
                word => word.Category == category);

            return categoryQuery;
        }
    }
}
