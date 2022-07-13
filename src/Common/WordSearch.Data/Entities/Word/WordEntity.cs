namespace WordSearch.Data.Entities.Word
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Words")]
    public class WordEntity
    {
        public int Id { get; set; }

        public string Value { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Language { get; set; } = null!;
    }
}
