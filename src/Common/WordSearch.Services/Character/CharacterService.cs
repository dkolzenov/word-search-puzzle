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
    using WordSearch.Core.Enums.Character;

    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;

        private readonly ICharacterRepository _characterRepository;

        public CharacterService(
            IMapper mapper,
            ICharacterRepository characterRepository)
        {
            _mapper = mapper;
            _characterRepository = characterRepository;
        }

        public async Task<List<CharacterModel>> GetCharactersAsync(
            ScriptType scriptType)
        {
            try
            {
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
