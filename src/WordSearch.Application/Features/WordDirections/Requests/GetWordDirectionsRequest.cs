using WordSearch.Application.Common.Interfaces;
using WordSearch.Common.Enums;

namespace WordSearch.Application.Features.WordDirections.Requests
{
    /// <summary>
    /// Тело запроса на получение направлений слов
    /// </summary>
    public class GetWordDirectionsRequest : IGetAllRequest
    {
        /// <summary>
        /// Тип расположения
        /// </summary>
        public LayoutType? LayoutType { get; set; }
        
        /// <summary>
        /// Тип направления
        /// </summary>
        public DirectionType? DirectionType { get; set; }
    }
}
