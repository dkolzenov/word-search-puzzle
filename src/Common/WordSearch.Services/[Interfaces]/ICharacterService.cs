namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Character.Enums;

    public interface ICharacterService
    {
        Task<List<string>> GetCharacters(FontType fontType);
    }
}
