namespace WordSearch.Models.DataGrid
{
    using System.Collections.Generic;

    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;

    public class DataGridModel
    {
        public GridModel Grid { get; set; } = null!;

        public List<WordModel> Words { get; set; } = null!;
    }
}
