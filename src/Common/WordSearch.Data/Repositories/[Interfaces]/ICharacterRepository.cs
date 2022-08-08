namespace WordSearch.Data.Repositories.Interfaces
{
    using System.Threading.Tasks;

    using WordSearch.Data.Entities.Character;
    using WordSearch.Core.Enums.Character;

    public interface ICharacterRepository : IRepositoryBase<CharacterEntity>
    {
        Task<CharacterEntity> GetCharactersAsync(ScriptType scriptType);
    }
}
