namespace WordSearch.Mappers.Converters
{
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Models.Character;
    using WordSearch.Data.Entities.Character;

    public class CharacterConverter
        : ITypeConverter<CharacterEntity, List<CharacterModel>>
    {
        public List<CharacterModel> Convert(
            CharacterEntity source,
            List<CharacterModel> destination,
            ResolutionContext context)
        {
            char[] characters = source.Characters.ToCharArray();

            foreach (var character in characters)
            {
                var characterModel = context.Mapper.Map<CharacterModel>(source);

                characterModel.Value = character;

                destination.Add(characterModel);
            }
            return destination;
        }
    }
}
