using WordSearch.Domain.Interfaces;

namespace WordSearch.Domain.Entities
{
    /// <summary>
    /// Настройки слов в сетке
    /// </summary>
    public class WordOnGridSettings : IBaseEntity
    {
        /// <inheritdoc />
        public long Id { get; set; }
        
        /// <summary>
        /// Длина слова
        /// </summary>
        public int WordLength { get; set; }
        
        /// <summary>
        /// Количество слов
        /// </summary>
        public int WordCount { get; set; }
        
        /// <summary>
        /// Идентификатор настроек игровой сессии
        /// </summary>
        public long GameSessionSettingsId { get; set; }

        /// <summary>
        /// Настройки игровой сессии
        /// </summary>
        public virtual GameSessionSettings GameSessionSettings { get; set; } = null!;
    }
}
