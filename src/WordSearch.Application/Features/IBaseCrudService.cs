using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Linq.PredicateBuilder;
using WordSearch.Application.Common.Interfaces;
using WordSearch.Domain.Interfaces;

namespace WordSearch.Application.Features
{
    /// <summary>
    /// Базовый CRUD сервис
    /// </summary>
    /// <typeparam name="TEntity"> Тип сущности </typeparam>
    public interface IBaseCrudService<TEntity> where TEntity : IBaseEntity
    {
        /// <summary>
        /// Получение списка моделей передачи данных
        /// </summary>
        /// <typeparam name="TDto"> Тип модели передачи данных </typeparam>
        /// <param name="builder"> Дерево запросов </param>
        /// <param name="cancellationToken"> Токен отмены </param>
        /// <param name="options"> Опции построителя </param>
        /// <returns> Список моделей передачи данных </returns>
        Task<IList<TDto>> GetAllAsync<TDto>(Func<IAndOrOperator<TEntity>, IResult<TEntity>> builder,
            CancellationToken cancellationToken = default,
            BuilderOptions options = BuilderOptions.IgnoreCase | BuilderOptions.IgnoreDefaultInputs | BuilderOptions.Trim)
            where TDto : IDto;

        /// <summary>
        /// Получение модели передачи данных по идентификатору
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        /// <param name="cancellationToken"> Токен отмены </param>
        /// <typeparam name="TDto"> Тип модели передачи данных </typeparam>
        /// <returns> Модель передачи данных </returns>
        Task<TDto> GetByIdAsync<TDto>(long id, CancellationToken cancellationToken = default) where TDto : IDto;

        /// <summary>
        /// Создание сущности
        /// </summary>
        /// <param name="request"> Объект тела запроса </param>
        /// <param name="cancellationToken"> Токен отмены </param>
        /// <typeparam name="TRequest"> Тип объекта тела запроса </typeparam>
        /// <returns> Идентификатор созданной сущности </returns>
        Task<long> CreateAsync<TRequest>(TRequest request, CancellationToken cancellationToken = default)
            where TRequest : ICreateRequest;

        /// <summary>
        /// Обновление сущности
        /// </summary>
        /// <param name="request"> Объект тела запроса </param>
        /// <param name="cancellationToken"> Токен отмены </param>
        /// <typeparam name="TRequest"> Тип объекта тела запроса </typeparam>
        Task UpdateAsync<TRequest>(TRequest request, CancellationToken cancellationToken = default)
            where TRequest : IUpdateRequest;

        /// <summary>
        /// Удаление сущности
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        /// <param name="cancellationToken"> Токен отмены </param>
        Task DeleteAsync(long id, CancellationToken cancellationToken = default);
    }
}
