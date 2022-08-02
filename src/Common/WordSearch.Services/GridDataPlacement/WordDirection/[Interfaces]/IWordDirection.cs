namespace WordSearch.Services.GridDataPlacement.WordDirection.Interfaces
{
    public interface IWordDirection
    {
        void MoveOnGrid(ref int row, ref int column);
    }

    public struct MovementState
    {
        public const int None = 0;

        public const int ShiftOneCell = 1;
    }
}
