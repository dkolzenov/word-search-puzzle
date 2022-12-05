using WordSearch.Common.Enums;
using WordSearch.Domain.Interfaces;

namespace WordSearch.Domain.Entities
{
    /// <summary>
    /// Настройки сетки
    /// </summary>
    public class GridSettings : IBaseEntity
    {
        /// <inheritdoc />
        public long Id { get; set; }
        
        /// <summary>
        /// Количество строк
        /// </summary>
        public int RowCount { get; set; }
        
        /// <summary>
        /// Количество столбцов
        /// </summary>
        public int ColumnCount { get; set; }
        
        /// <summary>
        /// Размер
        /// </summary>
        public GridSize Size { get; set; } 
    }
}
