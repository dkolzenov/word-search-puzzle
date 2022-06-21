namespace WordSearch.Models.Character
{
    using SQLite;

    [Table("Characters")]
    public class CharacterModel
    {
        [PrimaryKey, AutoIncrement, NotNull, Unique]
        public int Id { get; set; }

        [NotNull, Unique]
        public string Value { get; set; } = null!;

        [NotNull]
        public string Font { get; set; } = null!;
    }
}
