namespace WordSearch.Application.Common.Interfaces
{
    /// <summary>
    /// Интерфейс-маркер для автоматической регистрации scoped сервисов
    /// </summary>
    public interface IScopedService
    {
    }
    
    /// <summary>
    /// Интерфейс-маркер для автоматической регистрации singleton сервисов
    /// </summary>
    public interface ISingletonService
    {
    }
    
    /// <summary>
    /// Интерфейс-маркер для автоматической регистрации transient сервисов
    /// </summary>
    public interface ITransientService
    {
    }
}
