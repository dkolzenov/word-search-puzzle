namespace WordSearch.Services.Grid
{
    using System;
    using System.Threading.Tasks;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Grid.Enums;

    public class GridService : IGridService
    {
        public GridService()
        {
        }

        public Task<Array> GetGrid(SizeType size)
        {
            throw new NotImplementedException();
        }
    }
}
