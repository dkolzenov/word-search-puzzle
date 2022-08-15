namespace WordSearch.Services.Direction
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Helpers.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Direction;
    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;
    using WordSearch.Models.Cell;
    using WordSearch.Core.Enums.Direction;

    public class DirectionService : IDirectionService
    {
        private readonly IMapper _mapper;

        private readonly IRandomChooserHelper _randomChooserHelper;

        private readonly IDirectionRepository _directionRepository;

        public DirectionService(
            IMapper mapper,
            IRandomChooserHelper randomChooserHelper,
            IDirectionRepository directionRepository)
        {
            _mapper = mapper;
            _randomChooserHelper = randomChooserHelper;
            _directionRepository = directionRepository;
        }

        public async Task<List<DirectionModel>> GetDirectionsAsync(
            LayoutType layoutType)
        {
            try
            {
                var result = await _directionRepository
                    .GetDirectionsAsync(layoutType);

                var directions = _mapper.Map<List<DirectionModel>>(result);

                return directions;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<DirectionModel>>(
                    ex.InnerException);
            }
        }

        public async Task<DirectionModel?> GetValidRandomWordDirectionAsync(
            GridModel grid,
            WordModel word,
            CellModel startCell)
        {
            try
            {
                string characters = word.Value;

                List<LayoutType> layoutTypes = Enum
                    .GetValues(typeof(LayoutType))
                    .Cast<LayoutType>()
                    .ToList();

                while (layoutTypes.Count != 0)
                {
                    LayoutType randomLayoutType = _randomChooserHelper
                        .GetRandomItem(layoutTypes);

                    List<DirectionModel> directions = await GetDirectionsAsync(
                        randomLayoutType);

                    while (directions.Count != 0)
                    {
                        DirectionModel randomDirection = _randomChooserHelper
                            .GetRandomItem(directions);

                        foreach (var character in characters)
                        {
                            if ((!startCell.IsEmpty() &&
                                !startCell.IsContains(character)) ||
                                startCell.IsOutsideOfGrid(grid))
                            {
                                break;
                            }
                            else if (character == characters.Last())
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
