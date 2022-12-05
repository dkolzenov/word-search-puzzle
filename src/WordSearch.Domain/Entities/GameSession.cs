using System.Collections.Generic;
using WordSearch.Common.Enums;
using WordSearch.Domain.Interfaces;

namespace WordSearch.Domain.Entities
{
    /// <summary>
    /// Игровая сессия
    /// </summary>
    public class GameSession : IBaseEntity
    {
        /// <inheritdoc />
        public long Id { get; set; }
        
        /// <summary>
        /// Статус
        /// </summary>
        public GameSessionStatus Status { get; set; }

        /// <summary>
        /// Идентификатор настроек игровой сессии
        /// </summary>
        public long GameSessionSettingsId { get; set; }
        
        /// <summary>
        /// Настройки игровой сессии
        /// </summary>
        public virtual GameSessionSettings GameSessionSettings { get; set; } = null!;

        /// <summary>
        /// Слова в сетке
        /// </summary>
        public virtual List<WordOnGrid> WordsOnGrid { get; set; } = null!;

        /// <summary>
        /// Буквы в сетке
        /// </summary>
        public virtual List<CharacterOnGrid> CharactersOnGrid { get; set; } = null!;
    }
}
