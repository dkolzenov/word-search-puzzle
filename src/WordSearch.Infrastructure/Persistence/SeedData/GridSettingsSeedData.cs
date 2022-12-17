using System.Collections.Generic;
using WordSearch.Common.Enums;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.SeedData
{
    public static class GridSettingsSeedData
    {
        private static readonly IEnumerable<GridSettings> GridSettingsList;

        static GridSettingsSeedData()
        {
            GridSettingsList = new List<GridSettings>
            {
                new GridSettings
                {
                    Id = 1,
                    RowCount = 4,
                    ColumnCount = 4,
                    Size = GridSize.Small
                },
                new GridSettings
                {
                    Id = 2,
                    RowCount = 6,
                    ColumnCount = 6,
                    Size = GridSize.Medium
                },
                new GridSettings
                {
                    Id = 3,
                    RowCount = 8,
                    ColumnCount = 8,
                    Size = GridSize.Large
                }
            };
        }

        public static IEnumerable<GridSettings> Get() => GridSettingsList;
    }
}
