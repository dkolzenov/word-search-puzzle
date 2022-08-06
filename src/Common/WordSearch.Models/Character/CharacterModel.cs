namespace WordSearch.Models.Character
{
    public class CharacterModel
    {
        public int Id { get; set; }

        public char Value { get; set; }

        public string Script { get; set; } = null!;
    }
}
