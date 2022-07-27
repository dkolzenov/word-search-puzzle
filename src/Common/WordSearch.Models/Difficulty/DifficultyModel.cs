﻿namespace WordSearch.Models.Difficulty
{
    public class DifficultyModel
    {
        public int Id { get; set; }

        public string Value { get; set; } = null!;

        public string GridSize { get; set; } = null!;

        public int WordCount { get; set; }

        // TODO: Future updates

        //public int TimeLimit { get; set; }

        //public int ScoreMultiplier { get; set; }
    }
}
