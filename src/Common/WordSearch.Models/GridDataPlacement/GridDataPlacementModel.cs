﻿namespace WordSearch.Models.GridDataPlacement
{
    using System.Collections.Generic;

    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;

    public class GridDataPlacementModel
    {
        public GridModel DataGrid { get; set; } = null!;

        public List<WordModel> RandomWords { get; set; } = null!;
    }
}
