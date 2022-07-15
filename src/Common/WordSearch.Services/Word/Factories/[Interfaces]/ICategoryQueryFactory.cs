namespace WordSearch.Services.Word.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Word;

    public interface ICategoryQueryFactory
    {
        Expression<Func<WordEntity, bool>> CreateAnimalsQuery();

        Expression<Func<WordEntity, bool>> CreateVegetablesQuery();

        Expression<Func<WordEntity, bool>> CreateFruitsQuery();
    }
}
