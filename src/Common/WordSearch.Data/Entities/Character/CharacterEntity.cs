namespace WordSearch.Data.Entities.Character
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Characters")]
    public class CharacterEntity
    {
        public int Id { get; set; }

        public string Value { get; set; } = null!;

        public string Font { get; set; } = null!;
    }
}
