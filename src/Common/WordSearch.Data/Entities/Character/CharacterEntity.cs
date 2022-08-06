namespace WordSearch.Data.Entities.Character
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Character")]
    public class CharacterEntity
    {
        public int Id { get; set; }

        public string Characters { get; set; } = null!;

        public string Script { get; set; } = null!;
    }
}
