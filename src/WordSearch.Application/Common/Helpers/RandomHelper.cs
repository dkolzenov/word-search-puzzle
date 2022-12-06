using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSearch.Application.Common.Helpers
{
    /// <summary>
    /// Помощник по псевдо-случайной генерации
    /// </summary>
    public static class RandomHelper
    {
        /// <summary>
        /// Генератор псевдо-случайных чисел
        /// </summary>
        private static readonly Random Random;

        static RandomHelper()
        {
            Random = new Random();
        }

        public static int GenerateInteger(int minValue = 0, int maxValue = int.MaxValue)
        {
            return Random.Next(minValue, maxValue);
        }

        public static T GenerateEnumValue<T>() where T : Enum
        {
            var enumArray = Enum.GetValues(typeof(T));

            return (T)enumArray.GetValue(Random.Next(enumArray.Length));
        }

        public static T GenerateItem<T>(IList<T> sourceList)
        {
            return sourceList.ElementAt(Random.Next(sourceList.Count - 1));
        }
    }
}
