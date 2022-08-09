namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Grid;
    using WordSearch.Models.Character;

    public interface ICharacterInsertService
    {
        Task<GridModel> GetCharacterInsertedGrid(
            GridModel grid,
            List<CharacterModel> characters);
    }
}
