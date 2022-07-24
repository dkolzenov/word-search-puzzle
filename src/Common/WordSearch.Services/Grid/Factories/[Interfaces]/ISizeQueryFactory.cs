namespace WordSearch.Services.Grid.Factories.Interfaces
{
    using System;
    using System.Linq.Expressions;

    using WordSearch.Data.Entities.Grid;

    public interface ISizeQueryFactory
    {
        Expression<Func<GridEntity, bool>> CreateSmallQuery();

        Expression<Func<GridEntity, bool>> CreateMediumQuery();

        Expression<Func<GridEntity, bool>> CreateLargeQuery();
    }
}
