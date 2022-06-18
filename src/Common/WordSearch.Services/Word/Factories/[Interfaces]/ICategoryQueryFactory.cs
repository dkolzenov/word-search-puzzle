namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Models.Word;

    public interface ICategoryQueryFactory
    {
        Expression<Func<WordModel, bool>> CreateAnimalsQuery();

        Expression<Func<WordModel, bool>> CreateVegetablesQuery();

        Expression<Func<WordModel, bool>> CreateFruitsQuery();
    }
}
