namespace WordSearch.Services.GridDataPlacement.WordDirection.Interfaces
{
    public interface IWordDirection
    {
        void MoveInGrid(ref int row, ref int column);
    }

    public struct MovementState
    {
        public const int Stay = 0;

        public const int ShiftOneCell = 1;
    }
}
