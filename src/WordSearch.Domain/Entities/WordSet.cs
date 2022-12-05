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
        public string Category { get; set; } = null!;
        
        /// <summary>
        /// Длина слова
        /// </summary>
        public int WordLength { get; set; }
    }
}
