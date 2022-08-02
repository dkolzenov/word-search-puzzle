namespace WordSearch.Models.Cell
{
    using WordSearch.Models.Character;

    public class CellModel
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public CharacterModel Character { get; set; } = null!;
    }
}
