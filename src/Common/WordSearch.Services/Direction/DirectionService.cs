namespace WordSearch.Services.Direction
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.Direction;

    public class DirectionService : IDirectionService
    {
        public DirectionService()
        {
        }

        public Task<List<DirectionModel>> GetAllDirections()
        {
            throw new System.NotImplementedException();
        }

        public Task<DirectionModel> GetDirection()
        {
            throw new System.NotImplementedException();
        }
    }
}
