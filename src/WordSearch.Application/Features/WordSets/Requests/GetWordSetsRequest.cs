using WordSearch.Application.Common.Interfaces;
using WordSearch.Common.Enums;

namespace WordSearch.Application.Features.WordSets.Requests
{
    /// <summary>
    /// Тело запроса на получение наборов слов
    /// </summary>
    public class GetWordSetsRequest : IGetAllRequest
    {
        /// <summary>
        /// Категория
        /// </summary>
        public WordSetCategory? Category { get; set; }
        
        /// <summary>
        /// Язык
        /// </summary>
        public WordSetLanguage? Language { get; set; }
    }
}
