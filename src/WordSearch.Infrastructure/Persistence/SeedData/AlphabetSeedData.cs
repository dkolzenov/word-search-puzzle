using System.Collections.Generic;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.SeedData
{
    public static class AlphabetSeedData
    {
        private static readonly IEnumerable<Alphabet> Alphabets;

        static AlphabetSeedData()
        {
            Alphabets = new List<Alphabet>
            {
                new Alphabet
                {
                    Id = 1,
                    Characters = "abcdefghijklmnopqrstuvwxyz",
                    Script = "latin"
                },
                new Alphabet
                {
                    Id = 2,
                    Characters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя",
                    Script = "cyrillic"
                }
            };
        }

        public static IEnumerable<Alphabet> Get() => Alphabets;
    }
}
