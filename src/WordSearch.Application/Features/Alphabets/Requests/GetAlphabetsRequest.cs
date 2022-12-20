using WordSearch.Application.Common.Interfaces;
using WordSearch.Common.Enums;

namespace WordSearch.Application.Features.Alphabets.Requests
{
    /// <summary>
    /// Тело запроса на получение алфавитов
    /// </summary>
    public class GetAlphabetsRequest : IGetAllRequest
    {
        /// <summary>
        /// Форма письменности
        /// </summary>
        public AlphabetScript? Script { get; set; }
    }
}
