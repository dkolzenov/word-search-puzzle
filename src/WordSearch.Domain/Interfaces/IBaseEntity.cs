namespace WordSearch.Domain.Interfaces
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public interface IBaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
    }
}
