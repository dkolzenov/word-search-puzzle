namespace WordSearch.Models.Word
{
    using WordSearch.Core.Enums.Word;

    public class WordModel
    {
        public string Value { get; set; } = null!;

        public CategoryType Category { get; set; }

        public LanguageType Language { get; set; }
    }
}
