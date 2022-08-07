namespace WordSearch.Core.Dictionaries.Word
{
    using System.Collections.Generic;

    using WordSearch.Core.Enums.Word;

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
