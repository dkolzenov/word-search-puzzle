namespace WordSearch.Data.Entities
{
    /// <summary>
    /// Список слов
    /// </summary>
    public class WordSet
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Слова
        /// </summary>
        public string Words { get; set; }
        
        /// <summary>
        /// Категория
        /// </summary>
        public string Category { get; set; }
        
        /// <summary>
        /// Длина слова
        /// </summary>
        public int WordLength { get; set; }
    }
}
