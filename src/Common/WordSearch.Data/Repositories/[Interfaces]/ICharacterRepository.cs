namespace WordSearch.Data.Repositories.Interfaces
{
    using System;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Character;

    public interface ICharacterRepository : IRepository<CharacterModel>
    {
        Task<List<CharacterModel>> QueryCharacters(
            params Expression<Func<CharacterModel, bool>>[] predicates);
    }
}
