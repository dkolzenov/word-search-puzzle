using WordSearch.Application.Common.Interfaces;
using WordSearch.Application.Common.Mapping;
using WordSearch.Common.Enums;
using WordSearch.Domain.Entities;

namespace WordSearch.Application.Features.WordDirections.Dto
{
    /// <summary>
    /// Модель направления слова для передачи данных
    /// </summary>
    public class WordDirectionDto : IDto, IMapFrom<WordDirection>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
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
