namespace WordSearch.Services.Interfaces
{
    using System;
    using System.Threading.Tasks;

    using WordSearch.Services.Grid.Enums;

    public interface IGridService
    {
        Task<Array> GetGrid(SizeType size);
    }
}
