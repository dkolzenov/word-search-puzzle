using WordSearch.Application.Common.Interfaces;
using WordSearch.Application.Features.WordDirections.Dto;
using WordSearch.Application.Features.WordDirections.Requests;

namespace WordSearch.Application.Features.WordDirections
{
    /// <summary>
    /// CRUD сервис направления слова
    /// </summary>
    public interface IWordDirectionCrudService : ISingletonService
    {
        /// <summary>
        /// Получение списка направлений слов
        /// </summary>
        /// <param name="request">Тело запроса</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Список направлений слов</returns>
        Task<IList<WordDirectionDto>> GetWordDirections(GetWordDirectionsRequest request,
            CancellationToken cancellationToken = default);
    }
}
