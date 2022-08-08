namespace WordSearch.Services.Character
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Character;
    using WordSearch.Core.Enums.Word;
    using WordSearch.Core.Enums.Character;
    using WordSearch.Core.Dictionaries.Character;

    public class CharacterService : ICharacterService
    {
        private static readonly CharacterScriptMap _characterScriptMap;

        private readonly IMapper _mapper;

        private readonly ICharacterRepository _characterRepository;

        static CharacterService()
        {
            _characterScriptMap = new CharacterScriptMap();
        }

        public CharacterService(
            IMapper mapper,
            ICharacterRepository characterRepository)
        {
            _mapper = mapper;
            _characterRepository = characterRepository;
        }

        public async Task<List<CharacterModel>> GetCharactersAsync(
            LanguageType wordLanguageType)
        {
            try
            {
                ScriptType scriptType = _characterScriptMap
                    .GetScriptType(wordLanguageType);

                var result = await _characterRepository
                    .GetCharactersAsync(scriptType);

                var characters = _mapper
                    .Map<IEnumerable<CharacterModel>>(result)
                    .ToList();

                return characters;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<CharacterModel>>(
                    ex.InnerException);
            }
        }
    }
}
