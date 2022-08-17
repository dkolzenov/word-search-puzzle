namespace WordSearch.Models.GameSession
{
    using System;

    using WordSearch.Models.DataGrid;
    using WordSearch.Core.Enums.Word;

    public class GameSessionModel
    {
        public Guid Id { get; set; }

        public DataGridModel DataGrid { get; set; } = null!;

        public CategoryType WordCategory { get; set; }
    }
}
