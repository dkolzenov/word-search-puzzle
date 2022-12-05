using WordSearch.Domain.Interfaces;

namespace WordSearch.Domain.Entities
{
    /// <summary>
    /// Слово в сетке
    /// </summary>
    public class WordOnGrid : IBaseEntity
    {
        /// <inheritdoc />
        public long Id { get; set; }

        /// <summary>
        /// Слово
        /// </summary>
        public string Word { get; set; } = null!;

        /// <summary>
        /// Является найденным
        /// </summary>
        public bool IsFound { get; set; }

        /// <summary>
        /// Идентификатор набора слов
        /// </summary>
        public long WordSetId { get; set; }

        /// <summary>
        /// Набор слов
        /// </summary>
        public virtual WordSet WordSet { get; set; } = null!;
        
        /// <summary>
        /// Идентификатор направления слова
        /// </summary>
        public long WordDirectionId { get; set; }

        /// <summary>
        /// Направление слова
        /// </summary>
        public virtual WordDirection WordDirection { get; set; } = null!;
        
        /// <summary>
        /// Идентификатор игровой сессии
        /// </summary>
        public long GameSessionId { get; set; }

        /// <summary>
        /// Игровая сессия
        /// </summary>
        public virtual GameSession GameSession { get; set; } = null!;
    }
}
