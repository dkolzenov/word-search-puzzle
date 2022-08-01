﻿namespace WordSearch.Services.GridDataPlacement.WordDirection.Diagonal
{
    using WordSearch.Services.GridDataPlacement.WordDirection.Interfaces;

    public class LeftToBottom : IWordDirection
    {
        public void MoveInGrid(ref int row, ref int column)
        {
            row += MovementState.ShiftOneCell;
            column += MovementState.ShiftOneCell;
        }
    }
}