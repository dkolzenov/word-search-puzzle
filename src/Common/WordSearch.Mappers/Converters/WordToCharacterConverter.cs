namespace WordSearch.Mappers.Converters
{
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Models.Word;
    using WordSearch.Models.Character;
    using WordSearch.Core.Enums.Character;
    using WordSearch.Core.Dictionaries.Character;

    public class WordToCharacterConverter
        : ITypeConverter<WordModel, IEnumerable<CharacterModel>>
    {
        private static readonly CharacterScriptMap _characterScriptMap;

        static WordToCharacterConverter()
        {
            _characterScriptMap = new CharacterScriptMap();
        }

        public IEnumerable<CharacterModel> Convert(
            WordModel source,
            IEnumerable<CharacterModel> destination,
            ResolutionContext context)
        {
            char[] characters = source.Value.ToCharArray();

            foreach (var character in characters)
            {
                ScriptType script = _characterScriptMap
                    .GetScriptType(source.Language);

                yield return new CharacterModel()
                {
                    Value = character,
                    Script = script
                };
            }
        }
    }
}
