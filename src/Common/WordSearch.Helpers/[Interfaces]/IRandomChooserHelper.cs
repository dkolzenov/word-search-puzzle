namespace WordSearch.Helpers.Interfaces
{
    using System.Collections.Generic;

    public interface IRandomChooserHelper
    {
        T GetRandomChooseItem<T>(List<T> sourceList);

        List<T> GetRandomChooseList<T>(List<T> sourceList, int randomCount);
    }
}
