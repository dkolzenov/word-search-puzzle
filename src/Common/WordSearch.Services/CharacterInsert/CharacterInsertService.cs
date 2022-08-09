namespace WordSearch.Services.CharacterInsert
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Helpers.Interfaces;
    using WordSearch.Models.Grid;
    using WordSearch.Models.Character;

    public class CharacterInsertService : ICharacterInsertService
    {
        private readonly IRandomChooserHelper _randomChooserHelper;

        public CharacterInsertService(IRandomChooserHelper randomChooserHelper)
        {
            _randomChooserHelper = randomChooserHelper;
        }

        public async Task<GridModel> GetCharacterInsertedGrid(
            GridModel grid,
            List<CharacterModel> characters)
        {
            try
            {
                for (int i = 0; i < grid.Row; i++)
                {
                    for (int j = 0; j < grid.Column; j++)
                    {
                        if (grid[i, j].Character is null)
                        {
                            var randomCharacter = _randomChooserHelper
                                .GetRandomItem(characters);

                            grid[i, j].Character = randomCharacter;
                        }
                    }
                }
                return grid;
            }
            catch (Exception ex)
            {
                return await Task.FromException<GridModel>(ex.InnerException);
            }
        }
    }
}
