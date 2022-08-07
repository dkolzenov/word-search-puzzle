namespace WordSearch.Models.Grid
{
    using System;
    using System.Collections.Generic;

    using WordSearch.Models.Cell;
    using WordSearch.Core.Enums.Grid;

    public class GridModel
    {
        public int Id { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public SizeType Size { get; set; }

        public List<CellModel> Cells { get; set; } = null!;

        public CellModel this[int rowIndex, int columnIndex]
        {
            get
            {
                if (IsOutOfRange(rowIndex, columnIndex))
                    throw new ArgumentOutOfRangeException();

                int index = rowIndex * Column + columnIndex;

                return Cells[index];
            }
            set
            {
                if (IsOutOfRange(rowIndex, columnIndex))
                    throw new ArgumentOutOfRangeException();

                int index = rowIndex * Column + columnIndex;

                Cells[index] = value;
            }
        }

        private bool IsOutOfRange(int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || columnIndex < 0 ||
                rowIndex >= Row  || columnIndex >= Column)
            {
                return true;
            }
            return false;
        }
    }
}
