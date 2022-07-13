namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;

    using WordSearch.Data.Entities.Word;

    public interface ICategoryQueryFactory
    {
        Func<WordEntity, bool> CreateAnimalsQuery();

        Func<WordEntity, bool> CreateVegetablesQuery();

        Func<WordEntity, bool> CreateFruitsQuery();
    }
}
