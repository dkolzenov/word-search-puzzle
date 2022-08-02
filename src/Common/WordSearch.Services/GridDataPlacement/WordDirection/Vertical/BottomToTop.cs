namespace WordSearch.Services.GridDataPlacement.WordDirection.Vertical
{
    using WordSearch.Services.GridDataPlacement.WordDirection.Interfaces;

    public class BottomToTop : IWordDirection
    {
        public void MoveOnGrid(ref int row, ref int column)
        {
            row -= MovementState.ShiftOneCell;
            column += MovementState.None;
        }
    }
}
