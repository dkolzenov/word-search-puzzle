namespace WordSearch.Data.Repositories.Character
{
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.Character;
    using WordSearch.Data.Contexts.ApplicationDb;

    public class CharacterRepository
        : RepositoryBase<CharacterEntity>, ICharacterRepository
    {
        public CharacterRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
