namespace WordSearch.Services.Word.Dictionaries
{
    using System.Collections.Generic;

    using WordSearch.Services.Word.Enums;

    public class CategoryToStringMap
    {
        private readonly Dictionary<CategoryType, string> _map;

        public CategoryToStringMap()
        {
            _map = new Dictionary<CategoryType, string>()
            {
                {CategoryType.Animals,    "animals"},
                {CategoryType.Vegetables, "vegetables"},
                {CategoryType.Fruits,     "fruits"}
            };
        }

        public string GetCategoryString(CategoryType categoryType)
        {
            return _map[categoryType];
        }
    }
}
