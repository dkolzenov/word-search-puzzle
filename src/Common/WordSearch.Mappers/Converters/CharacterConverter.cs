namespace WordSearch.Mappers.Converters
{
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Models.Character;
    using WordSearch.Data.Entities.Character;

    public class CharacterConverter
        : ITypeConverter<CharacterEntity, IEnumerable<CharacterModel>>
    {
        public IEnumerable<CharacterModel> Convert(
            CharacterEntity source,
            IEnumerable<CharacterModel> destination,
            ResolutionContext context)
        {
            char[] characters = source.Characters.ToCharArray();

            foreach (var character in characters)
            {
                var characterModel = context.Mapper.Map<CharacterModel>(source);

                characterModel.Value = character;

                yield return characterModel;
            }
        }
    }
}
