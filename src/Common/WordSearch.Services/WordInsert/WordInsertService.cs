﻿namespace WordSearch.Services.WordInsert
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Helpers.Interfaces;
    using WordSearch.Models.Grid;
    using WordSearch.Models.Word;
    using WordSearch.Models.Cell;
    using WordSearch.Models.Character;
    using WordSearch.Models.Direction;

    public class WordInsertService : IWordInsertService
    {
        private readonly IMapper _mapper;

        private readonly IDirectionService _directionService;

        private readonly IRandomChooserHelper _randomChooserHelper;

        public WordInsertService(
            IMapper mapper,
            IDirectionService directionService,
            IRandomChooserHelper randomChooserHelper)
        {
            _mapper = mapper;
            _directionService = directionService;
            _randomChooserHelper = randomChooserHelper;
        }

        public async Task<GridModel> GetWordInsertedGrid(
            GridModel grid,
            WordModel word)
        {
            try
            {
                List<CellModel> emptyCells = grid.Cells
                    .Where(cell => cell.Character is null)
                    .ToList();

                while (emptyCells.Count != 0)
                {
                    CellModel cell = _randomChooserHelper
                        .GetRandomItem(emptyCells);

                    DirectionModel? direction = await _directionService
                        .GetValidRandomWordDirectionAsync(grid, word, cell);

                    if (!(direction is null))
                    {
                        var characters = _mapper
                            .Map<IEnumerable<CharacterModel>>(word)
                            .ToList();

                        characters.ForEach(character =>
                            grid[cell.Row, cell.Column].Character = character);
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
