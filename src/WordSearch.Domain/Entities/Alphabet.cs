using WordSearch.Domain.Interfaces;

namespace WordSearch.Domain.Entities
{
    /// <summary>
    /// Алфавит
    /// </summary>
    public class Alphabet : IBaseEntity
    {
        /// <inheritdoc />
        public long Id { get; set; }

        /// <summary>
        /// Буквы
        /// </summary>
        public string Characters { get; set; } = null!;

        /// <summary>
        /// Форма письменности
        /// </summary>
        public string Script { get; set; } = null!;
    }
}
