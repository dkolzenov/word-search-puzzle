namespace WordSearch.Services.GridDataPlacement.WordDirection.Horizontal
{
    using WordSearch.Services.GridDataPlacement.WordDirection.Interfaces;

    public class RightToLeft : IWordDirection
    {
        public void MoveOnGrid(ref int row, ref int column)
        {
            row += MovementState.None;
            column -= MovementState.ShiftOneCell;
        }
    }
}
