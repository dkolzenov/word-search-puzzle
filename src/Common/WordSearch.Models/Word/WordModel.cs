namespace WordSearch.Models.Word
{
    using SQLite;

    [Table("Words")]
    public class WordModel
    {
        [PrimaryKey, AutoIncrement, NotNull, Unique]
        public int Id { get; set; }

        [NotNull, Unique]
        public string Value { get; set; } = null!;

        [NotNull]
        public string Category { get; set; } = null!;

        [NotNull]
        public string Language { get; set; } = null!;
    }
}
