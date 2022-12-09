using WordSearch.Common.Enums;
using WordSearch.Domain.Interfaces;

namespace WordSearch.Domain.Entities
{
    /// <summary>
    /// Набор слов
    /// </summary>
    public class WordSet : IBaseEntity
    {
        /// <inheritdoc />
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
