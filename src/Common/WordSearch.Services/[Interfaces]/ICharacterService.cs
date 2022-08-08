﻿namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Character;
    using WordSearch.Core.Enums.Character;

    public interface ICharacterService
    {
        Task<List<CharacterModel>> GetCharactersAsync(ScriptType scriptType);
    }
}
