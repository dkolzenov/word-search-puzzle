using WordSearch.Application.Common.Interfaces;
using WordSearch.Application.Features.Alphabets.Dto;
using WordSearch.Application.Features.Alphabets.Requests;

namespace WordSearch.Application.Features.Alphabets
{
    /// <summary>
    /// CRUD сервис алфавита
    /// </summary>
    public interface IAlphabetCrudService : ISingletonService
    {
        /// <summary>
        /// Получение списка алфавитов
        /// </summary>
        /// <param name="request">Тело запроса</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Список алфавитов</returns>
        Task<IList<AlphabetDto>> GetAlphabets(GetAlphabetsRequest request, CancellationToken cancellationToken = default);
    }
}
