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

        public T GetRandomChooseItem<T>(List<T> sourceList)
        {
            int randomIndex = s_random.Next(sourceList.Count - 1);

            T randomChooseItem = sourceList.ElementAt(randomIndex);

            return randomChooseItem;
        }

        public List<T> GetRandomChooseList<T>(List<T> sourceList, int randomCount)
        {
            var randomChooseSet = new HashSet<T>();

            while (randomChooseSet.Count != randomCount)
            {
                int randomIndex = s_random.Next(sourceList.Count - 1);
                randomChooseSet.Add(sourceList.ElementAt(randomIndex));
            }

            List<T> randomChooseList = randomChooseSet.ToList();

            return randomChooseList;
        }
    }
}
