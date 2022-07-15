namespace WordSearch.Services.Character
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Character.Factories.Interfaces;
    using WordSearch.Services.Character.Enums;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Entities.Character;

    public class CharacterService : ICharacterService
    {
        private readonly ICharacterQueryFactory _characterFactory;

        private readonly ICharacterRepository _characterRepository;

        public CharacterService(
            ICharacterQueryFactory characterFactory,
            ICharacterRepository characterRepository)
        {
            _characterFactory = characterFactory;
            _characterRepository = characterRepository;
        }

        public async Task<List<string>> GetCharacters(FontType fontType)
        {
            try
            {
                var fontQuery = _characterFactory.CreateFontQuery(fontType);

                var result = await _characterRepository.QueryAsync(fontQuery);

                var characters = ConvertToStringList(result);

                return characters;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<string>>(
                    ex.InnerException);
            }
        }

        private List<string> ConvertToStringList(
            List<CharacterEntity> characters)
        {
            var stringList = new List<string>();

            characters.ForEach(character => stringList.Add(character.Value));

            return stringList;
        }
    }
}
