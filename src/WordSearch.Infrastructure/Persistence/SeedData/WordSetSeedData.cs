using System.Collections.Generic;
using WordSearch.Common.Enums;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.SeedData
{
    public static class WordSetSeedData
    {
        private static readonly IEnumerable<WordSet> WordSets;

        static WordSetSeedData()
        {
            WordSets = new List<WordSet>
            {
                new WordSet
                {
                    Id = 1,
                    Words = "бык жук кит кот лев рак сом сыч чиж ара аист барс бобр волк гусь енот жаба заяц змея " +
                            "клоп конь краб лось морж мышь белка бизон выдра гиена жираф зебра кабан коала кошка " +
                            "лемур манул норка олень панда песец питон скунс хомяк цапля чайка ягуар кобра",
                    
                    Category = WordSetCategory.Animals,
                    Language = WordSetLanguage.Russian
                },
                new WordSet
                {
                    Id = 2,
                    Words = "лук ром сок уха чай рис сыр суп мёд эль",
                    Category = WordSetCategory.Food,
                    Language = WordSetLanguage.Russian
                },
                new WordSet
                {
                    Id = 3,
                    Words = "",
                    Category = WordSetCategory.Animals,
                    Language = WordSetLanguage.English
                },
                new WordSet
                {
                    Id = 4,
                    Words = "",
                    Category = WordSetCategory.Food,
                    Language = WordSetLanguage.English
                }
            };
        }

        public static IEnumerable<WordSet> Get() => WordSets;
    }
}
