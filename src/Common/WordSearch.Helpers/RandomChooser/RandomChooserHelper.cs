namespace WordSearch.Helpers.RandomChooser
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using WordSearch.Helpers.Interfaces;

    public class RandomChooserHelper : IRandomChooserHelper
    {
        private static readonly Random s_random;

        static RandomChooserHelper()
        {
            s_random = new Random();
        }

        public int GetRandomIntValue(
            int minValue = 0,
            int maxValue = int.MaxValue)
        {
            return s_random.Next(minValue, maxValue);
        }

        public T GetRandomEnumValue<T>() where T : Enum
        {
            Array enumArray = Enum.GetValues(typeof(T));

            int randomIndex = s_random.Next(enumArray.Length);

            T randomEnumValue = (T)enumArray.GetValue(randomIndex);

            return randomEnumValue;
        }

        public T GetRandomItem<T>(List<T> sourceList)
        {
            int randomIndex = s_random.Next(sourceList.Count - 1);

            T randomItem = sourceList.ElementAt(randomIndex);

            return randomItem;
        }

        public List<T> GetRandomUniqueList<T>(List<T> sourceList, int randomCount)
        {
            var randomSet = new HashSet<T>();

            while (randomSet.Count != randomCount)
            {
                int randomIndex = s_random.Next(sourceList.Count - 1);
                randomSet.Add(sourceList.ElementAt(randomIndex));
            }

            List<T> randomList = randomSet.ToList();

            return randomList;
        }
    }
}
