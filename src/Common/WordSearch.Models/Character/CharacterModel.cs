namespace WordSearch.Models.Character
{
    using System.Collections.Generic;

    public class CharacterModel
    {
        public int Id { get; set; }

        public List<char> Characters { get; set; } = null!;

        public string Sctipt { get; set; } = null!;
    }
}
