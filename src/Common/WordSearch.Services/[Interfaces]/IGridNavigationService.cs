namespace WordSearch.Services.Interfaces
{
    using WordSearch.Models.GridNavigation;

    public interface IGridNavigationService
    {
        bool Move(ref GridNavigationModel gridNavigation);
    }
}
