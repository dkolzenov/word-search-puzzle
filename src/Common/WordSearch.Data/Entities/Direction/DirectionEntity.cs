﻿namespace WordSearch.Data.Entities.Direction
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Direction")]
    public class DirectionEntity
    {
        public int Id { get; set; }

        public int RowMovement { get; set; }

        public int ColumnMovement { get; set; }

        public string Layout { get; set; } = null!;

        public string DirectionType { get; set; } = null!;
    }
}
