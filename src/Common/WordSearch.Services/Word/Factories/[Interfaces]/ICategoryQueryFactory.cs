namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;

    using WordSearch.Models.Word;

    public interface ICategoryQueryFactory
    {
        Func<WordModel, bool> CreateAnimalsQuery();

        Func<WordModel, bool> CreateVegetablesQuery();

        Func<WordModel, bool> CreateFruitsQuery();
    }
}
