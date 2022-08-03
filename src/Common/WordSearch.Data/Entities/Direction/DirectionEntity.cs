namespace WordSearch.Data.Entities.Direction
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Directions")]
    public class DirectionEntity
    {
        public int Id { get; set; }

        public int RowMovement { get; set; }

        public int ColumnMovement { get; set; }

        public string LayoutType { get; set; } = null!;

        public string DirectionType { get; set; } = null!;
    }
}
