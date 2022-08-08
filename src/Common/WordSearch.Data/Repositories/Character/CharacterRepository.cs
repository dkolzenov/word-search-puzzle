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
    using WordSearch.Core.Dictionaries.Character;

    public class CharacterRepository
        : RepositoryBase<CharacterEntity>, ICharacterRepository
    {
        private readonly ScriptToStringMap _scriptMap;

        public CharacterRepository(ApplicationDbContext context) : base(context)
        {
            _scriptMap = new ScriptToStringMap();
        }

        public async Task<CharacterEntity> GetCharactersAsync(
            ScriptType scriptType)
        {
            try
            {
                string script = _scriptMap.GetScriptString(scriptType);

                var result = await QueryAsync(
                    characters => characters.Script == script);

                CharacterEntity characters = result.FirstOrDefault();

                return characters;
            }
            catch (Exception ex)
            {
                return await Task.FromException<CharacterEntity>(ex);
            }
        }
    }
}
