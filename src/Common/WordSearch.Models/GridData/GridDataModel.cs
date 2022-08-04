namespace WordSearch.Models.DataGrid
{
    using System.Collections.Generic;

    using WordSearch.Models.Word;
    using WordSearch.Models.Character;

    public class GridDataModel
    {
        public List<WordModel> Words { get; set; } = null!;

        public List<CharacterModel> Characters { get; set; } = null!;
    }
}
