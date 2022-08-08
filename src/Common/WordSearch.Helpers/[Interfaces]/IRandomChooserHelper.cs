namespace WordSearch.Helpers.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IRandomChooserHelper
    {
        int GetRandomIntValue(int minValue = 0, int maxValue = int.MaxValue);

        T GetRandomEnumValue<T>() where T : Enum;

        T GetRandomItem<T>(List<T> sourceList);

        List<T> GetRandomUniqueList<T>(List<T> sourceList, int randomCount);
    }
}
