namespace WordSearch.Data.Repositories.Character
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Repositories.Base;
    using WordSearch.Data.Entities.Character;
    using WordSearch.Data.Contexts.ApplicationDb;
    using WordSearch.Core.Enums.Character;

    public class CharacterRepository
        : RepositoryBase<CharacterEntity>, ICharacterRepository
    {
        public CharacterRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<CharacterEntity> GetCharactersAsync(
            ScriptType scriptType)
        {
            try
            {
                string script = scriptType.ToString().ToLower();

                var result = await QueryAsync(
                    character => character.Script == script);

                CharacterEntity characters = result.FirstOrDefault();

                return characters;
            }
            catch (Exception ex)
            {
                return await Task.FromException<CharacterEntity>(
                    ex.InnerException);
            }
        }
    }
}
