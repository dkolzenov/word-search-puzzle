namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Character.Enums;
    using WordSearch.Models.Character;

    public interface ICharacterService
    {
        Task<List<CharacterModel>> GetCharacters(FontType fontType);
    }
}
