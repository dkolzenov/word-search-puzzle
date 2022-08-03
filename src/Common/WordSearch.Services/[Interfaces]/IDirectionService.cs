namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Direction;

    public interface IDirectionService
    {
        Task<List<DirectionModel>> GetAllDirections();

        Task<DirectionModel> GetDirection();
    }
}
