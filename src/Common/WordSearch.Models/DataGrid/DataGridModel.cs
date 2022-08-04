namespace WordSearch.Models.DataGrid
{
    using System.Collections.Generic;

    using WordSearch.Models.Word;
    using WordSearch.Models.Cell;
    using WordSearch.Models.Character;

    public class DataGridModel
    {
        public List<WordModel> Words { get; set; } = null!;

        public List<CharacterModel> Characters { get; set; } = null!;

        public List<CellModel> Cells { get; set; } = null!;
    }
}
