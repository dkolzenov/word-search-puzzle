namespace WordSearch.Services.Character
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Character.Factories.Interfaces;
    using WordSearch.Services.Character.Enums;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Character;

    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;

        private readonly ICharacterQueryFactory _characterFactory;

        private readonly ICharacterRepository _characterRepository;

        public CharacterService(
            IMapper mapper,
            ICharacterQueryFactory characterFactory,
            ICharacterRepository characterRepository)
        {
            _mapper = mapper;
            _characterFactory = characterFactory;
            _characterRepository = characterRepository;
        }

        public async Task<List<CharacterModel>> GetCharacters(
            ScriptType scriptType)
        {
            try
            {
                var scriptQuery = _characterFactory
                    .CreateScriptQuery(scriptType);

                var result = await _characterRepository
                    .QueryAsync(scriptQuery);

                var characters = _mapper
                    .Map<IEnumerable<CharacterModel>>(result[0])
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
