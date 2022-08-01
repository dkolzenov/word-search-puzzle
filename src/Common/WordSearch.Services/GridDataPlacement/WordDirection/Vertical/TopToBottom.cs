namespace WordSearch.Services.GridDataPlacement.WordDirection.Vertical
{
    using WordSearch.Services.GridDataPlacement.WordDirection.Interfaces;

    public class TopToBottom : IWordDirection
    {
        public void MoveInGrid(ref int row, ref int column)
        {
            row += MovementState.ShiftOneCell;
            column += MovementState.None;
        }
    }
}
