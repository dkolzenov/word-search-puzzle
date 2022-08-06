namespace WordSearch.Data.Entities.Grid
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Grid")]
    public class GridEntity
    {
        public int Id { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public string Size { get; set; } = null!;
    }
}
