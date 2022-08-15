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
    using WordSearch.Models.Direction;
    using WordSearch.Core.Enums.Direction;

    public class WordDirectionService : IWordDirectionService
    {
        private readonly IDirectionService _directionService;

        private readonly IRandomChooserHelper _randomChooserHelper;

        public WordDirectionService(
            IDirectionService directionService,
            IRandomChooserHelper randomChooserHelper)
        {
            _directionService = directionService;
            _randomChooserHelper = randomChooserHelper;
        }

        public async Task<DirectionModel?> GetValidRandomDirection(
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

                        foreach (var character in word.Value)
                        {
                            if ((!startCell.IsEmpty() &&
                                !startCell.IsContains(character)) ||
                                startCell.IsOutsideOfGrid(grid))
                            {
                                break;
                            }
                            else if (character == word.Value.Last())
                            {
                                return randomDirection;
                            }
                            startCell.Row += randomDirection.RowMovement;
                            startCell.Column += randomDirection.ColumnMovement;
                        }
                        directions.Remove(randomDirection);
                    }
                    layoutTypes.Remove(randomLayoutType);
                }
                return null;
            }
            catch (Exception ex)
            {
                return await Task.FromException<DirectionModel>(
                    ex.InnerException);
            }
        }
    }

    internal static class CellExtension
    {
        public static bool IsEmpty(this CellModel cell)
        {
            return cell.Character.Value is char.MinValue;
        }

        public static bool IsContains(this CellModel cell, char character)
        {
            return cell.Character.Value == character;
        }

        public static bool IsOutsideOfGrid(this CellModel cell, GridModel grid)
        {
            return cell.Row > grid.Row || cell.Column > grid.Column;
        }
    }
}
