using WordSearch.Common.Enums;
using WordSearch.Domain.Interfaces;

namespace WordSearch.Domain.Entities
{
    /// <summary>
    /// Направление слова
    /// </summary>
    public class WordDirection : IBaseEntity
    {
        /// <inheritdoc />
        public long Id { get; set; }
        
        /// <summary>
        /// Сдвиг по строкам
        /// </summary>
        public int RowMovement { get; set; }
        
        /// <summary>
        /// Сдвиг по столбцам
        /// </summary>
        public int ColumnMovement { get; set; }
        
        /// <summary>
        /// Тип расположения
        /// </summary>
        public LayoutType LayoutType { get; set; }
        
        /// <summary>
        /// Тип направления
        /// </summary>
        public DirectionType DirectionType { get; set; }
    }
}
