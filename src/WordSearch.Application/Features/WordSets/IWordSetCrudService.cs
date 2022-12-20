using WordSearch.Application.Common.Interfaces;
using WordSearch.Application.Features.WordSets.Dto;
using WordSearch.Application.Features.WordSets.Requests;

namespace WordSearch.Application.Features.WordSets
{
    /// <summary>
    /// CRUD сервис набора слов
    /// </summary>
    public interface IWordSetCrudService : ISingletonService
    {
        /// <summary>
        /// Получение списка наборов слов
        /// </summary>
        /// <param name="request">Тело запроса</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Список наборов слов</returns>
        Task<IList<WordSetDto>> GetWordSets(GetWordSetsRequest request, CancellationToken cancellationToken = default);
    }
}
