using WordSearch.Application.Common.Interfaces;
using WordSearch.Application.Common.Mapping;
using WordSearch.Common.Enums;
using WordSearch.Domain.Entities;

namespace WordSearch.Application.Features.WordSets.Dto
{
    /// <summary>
    /// Модель набора слов для передачи данных
    /// </summary>
    public class WordSetDto : IDto, IMapFrom<WordSet>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Слова
        /// </summary>
        public string Words { get; set; } = null!;

        /// <summary>
        /// Категория
        /// </summary>
        public WordSetCategory Category { get; set; }

        /// <summary>
        /// Язык
        /// </summary>
        public WordSetLanguage Language { get; set; }
    }
}
