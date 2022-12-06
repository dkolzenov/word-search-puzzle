namespace WordSearch.Application.Common.Interfaces
{
    /// <summary>
    /// Интерфейс тела запроса Update
    /// </summary>
    public interface IUpdateRequest
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }
    }
}
