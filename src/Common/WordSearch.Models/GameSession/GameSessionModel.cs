namespace WordSearch.Models.GameSession
{
    using System.Collections.Generic;

    using WordSearch.Models.Word;
    using WordSearch.Models.Grid;

    public class GameSessionModel
    {
        public int Id { get; set; }

        public GridModel Grid { get; set; } = null!;

        public List<WordModel> Words { get; set; } = null!;

        public string WordCategory { get; set; } = null!;
    }
}
