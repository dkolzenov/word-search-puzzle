using System.Collections.Generic;
using WordSearch.Common.Enums;
using WordSearch.Domain.Interfaces;

namespace WordSearch.Domain.Entities
{
    /// <summary>
    /// Настройки игровой сессии
    /// </summary>
    public class GameSessionSettings : IBaseEntity
    {
        /// <inheritdoc />
        public long Id { get; set; }
        
        /// <summary>
        /// Идентификатор настроек сетки
        /// </summary>
        public long GridSettingsId { get; set; }

        /// <summary>
        /// Настройки сетки
        /// </summary>
        public virtual GridSettings GridSettings { get; set; } = null!;

        /// <summary>
        /// Список настроек слов в сетке
        /// </summary>
        public virtual List<WordOnGridSettings> WordOnGridSettingsList { get; set; } = null!;
        
        /// <summary>
        /// Уровень сложности
        /// </summary>
        public GameDifficulty Difficulty { get; set; }
    }
}
