using WordSearch.Domain.Interfaces;

namespace WordSearch.Domain.Entities
{
    /// <summary>
    /// Буква в сетке
    /// </summary>
    public class CharacterOnGrid : IBaseEntity
    {
        /// <inheritdoc />
        public long Id { get; set; }

        /// <summary>
        /// Буква
        /// </summary>
        public string Character { get; set; } = null!;
        
        /// <summary>
        /// Строка
        /// </summary>
        public int Row { get; set; }
        
        /// <summary>
        /// Столбец
        /// </summary>
        public int Column { get; set; }
        
        /// <summary>
        /// Идентификатор алфавита
        /// </summary>
        public long AlphabetId { get; set; }

        /// <summary>
        /// Алфавит
        /// </summary>
        public virtual Alphabet Alphabet { get; set; } = null!;
        
        /// <summary>
        /// Идентификатор слова в сетке
        /// </summary>
        public long WordOnGridId { get; set; }

        /// <summary>
        /// Слово в сетке
        /// </summary>
        public virtual WordOnGrid WordOnGrid { get; set; } = null!;
        
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
