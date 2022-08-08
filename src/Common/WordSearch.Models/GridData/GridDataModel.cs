namespace WordSearch.Models.GridData
{
    using System.Collections.Generic;

    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;
    using WordSearch.Models.Character;

    public class GridDataModel
    {
        public GridModel Grid { get; set; } = null!;

        public List<WordModel> Words { get; set; } = null!;

        public List<CharacterModel> Characters { get; set; } = null!;

        public int WordCount { get; set; }
    }
}
