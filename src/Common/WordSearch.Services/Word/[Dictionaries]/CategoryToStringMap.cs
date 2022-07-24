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
                {CategoryType.Animals,    "Животные"},
                {CategoryType.Animals,    "Animals"},

                {CategoryType.Vegetables, "Овощи"},
                {CategoryType.Vegetables, "Vegetables"},

                {CategoryType.Fruits,     "Фрукты"},
                {CategoryType.Fruits,     "Fruits"}
            };
        }

        public string GetItemString(CategoryType categoryType)
        {
            return _map[categoryType];
        }
    }
}
