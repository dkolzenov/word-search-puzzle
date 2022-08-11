namespace WordSearch.Services.WordDirection
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Helpers.Interfaces;
    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;
    using WordSearch.Models.Cell;
    using WordSearch.Models.Character;
    using WordSearch.Models.Direction;
    using WordSearch.Core.Enums.Direction;

    public class WordDirectionService : IWordDirectionService
    {
        private readonly Predicate<CharacterModel> IsCharacterNull = (x) => x is null;

        private readonly IDirectionService _directionService;

        private readonly IRandomChooserHelper _randomChooserHelper;

        public WordDirectionService(
            IDirectionService directionService,
            IRandomChooserHelper randomChooserHelper)
        {
            _directionService = directionService;
            _randomChooserHelper = randomChooserHelper;
        }

        public async Task<DirectionModel> GetPossibleRandomDirection(
            GridModel grid,
            WordModel word,
            CellModel startCell)
        {
            try
            {
                List<LayoutType> layoutTypes = Enum
                    .GetValues(typeof(LayoutType))
                    .Cast<LayoutType>()
                    .ToList();

                while (layoutTypes.Count != 0)
                {
                    LayoutType randomLayoutType = _randomChooserHelper
                        .GetRandomItem(layoutTypes);

                    List<DirectionModel> directions = await _directionService
                        .GetDirectionsAsync(randomLayoutType);

                    while (directions.Count != 0)
                    {
                        DirectionModel randomDirection = _randomChooserHelper
                            .GetRandomItem(directions);

                        string characters = word.Value;

                        foreach (var character in characters)
                        {
                            // TODO: continue...
                            if (IsCharacterNull(startCell.Character) ||
                                startCell.Character.Value != character)
                            {
                                startCell.Row += randomDirection.RowMovement;
                                startCell.Column += randomDirection.ColumnMovement;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return await Task.FromException<DirectionModel>(
                    ex.InnerException);
            }
        }
    }
}
