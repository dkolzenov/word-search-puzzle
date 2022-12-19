using WordSearch.Application.Common.Interfaces;
using WordSearch.Application.Common.Mapping;
using WordSearch.Common.Enums;
using WordSearch.Domain.Entities;

namespace WordSearch.Application.Features.Alphabets.Dto
{
    /// <summary>
    /// Модель алфавита для передачи данных
    /// </summary>
    public class AlphabetDto : IDto, IMapFrom<Alphabet>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Буквы
        /// </summary>
        public string Characters { get; set; } = null!;

        /// <summary>
        /// Форма письменности
        /// </summary>
        public AlphabetScript Script { get; set; }
    }
}
