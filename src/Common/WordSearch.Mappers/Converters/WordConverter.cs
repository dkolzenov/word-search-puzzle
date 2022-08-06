namespace WordSearch.Mappers.Converters
{
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Models.Word;
    using WordSearch.Data.Entities.Word;

    public class WordConverter : ITypeConverter<WordEntity, List<WordModel>>
    {
        private const string SplitSeparator = " ";

        public List<WordModel> Convert(
            WordEntity source,
            List<WordModel> destination,
            ResolutionContext context)
        {
            string[] words = source.Words.Split(SplitSeparator);

            foreach (var word in words)
            {
                var wordModel = context.Mapper.Map<WordModel>(source);

                wordModel.Value = word;

                destination.Add(wordModel);
            }
            return destination;
        }
    }
}
