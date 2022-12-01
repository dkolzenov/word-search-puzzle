namespace WordSearch.Data.Entities
{
    /// <summary>
    /// Алфавит
    /// </summary>
    public class Alphabet
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Буквы
        /// </summary>
        public string Characters { get; set; }

        /// <summary>
        /// Форма письменности
        /// </summary>
        public string Script { get; set; }
    }
}
