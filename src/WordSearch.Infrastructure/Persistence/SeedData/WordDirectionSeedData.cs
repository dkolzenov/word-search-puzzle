using System.Collections.Generic;
using WordSearch.Common.Enums;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.SeedData
{
    public static class WordDirectionSeedData
    {
        private static readonly IEnumerable<WordDirection> WordDirections;

        static WordDirectionSeedData()
        {
            WordDirections = new List<WordDirection>
            {
                new WordDirection
                {
                    Id = 1,
                    RowMovement = 0,
                    ColumnMovement = 1,
                    LayoutType = LayoutType.Horizontal,
                    DirectionType = DirectionType.LeftToRight
                },
                new WordDirection
                {
                    Id = 2,
                    RowMovement = 0,
                    ColumnMovement = -1,
                    LayoutType = LayoutType.Horizontal,
                    DirectionType = DirectionType.RightToLeft
                },
                new WordDirection
                {
                    Id = 3,
                    RowMovement = 1,
                    ColumnMovement = 0,
                    LayoutType = LayoutType.Vertical,
                    DirectionType = DirectionType.TopToBottom
                },
                new WordDirection
                {
                    Id = 4,
                    RowMovement = -1,
                    ColumnMovement = 0,
                    LayoutType = LayoutType.Vertical,
                    DirectionType = DirectionType.BottomToTop
                },
                new WordDirection
                {
                    Id = 5,
                    RowMovement = 1,
                    ColumnMovement = 1,
                    LayoutType = LayoutType.Diagonal,
                    DirectionType = DirectionType.TopLeftToBottomRight
                },
                new WordDirection
                {
                    Id = 6,
                    RowMovement = -1,
                    ColumnMovement = -1,
                    LayoutType = LayoutType.Diagonal,
                    DirectionType = DirectionType.BottomRightToTopLeft
                },
                new WordDirection
                {
                    Id = 7,
                    RowMovement = -1,
                    ColumnMovement = 1,
                    LayoutType = LayoutType.Diagonal,
                    DirectionType = DirectionType.BottomLeftToTopRight
                },
                new WordDirection
                {
                    Id = 8,
                    RowMovement = 1,
                    ColumnMovement = -1,
                    LayoutType = LayoutType.Diagonal,
                    DirectionType = DirectionType.TopRightToBottomLeft
                }
            };
        }

        public static IEnumerable<WordDirection> Get() => WordDirections;
    }
}
