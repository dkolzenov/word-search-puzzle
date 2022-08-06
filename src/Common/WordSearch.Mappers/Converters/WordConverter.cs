namespace WordSearch.Mappers.Converters
{
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Models.Word;
    using WordSearch.Data.Entities.Word;

    public class WordConverter
        : ITypeConverter<WordEntity, IEnumerable<WordModel>>
    {
        private const string SplitSeparator = " ";

        public IEnumerable<WordModel> Convert(
            WordEntity source,
            IEnumerable<WordModel> destination,
            ResolutionContext context)
        {
            string[] words = source.Words.Split(SplitSeparator);

            foreach (var word in words)
            {
                var wordModel = context.Mapper.Map<WordModel>(source);

                wordModel.Value = word;

                yield return wordModel;
            }
        }
    }
}
