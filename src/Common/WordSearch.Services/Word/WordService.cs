namespace WordSearch.Services.Word
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Word;
    using WordSearch.Core.Enums.Word;

    public class WordService : IWordService
    {
        private readonly IMapper _mapper;

        private readonly IWordQueryFactory _wordFactory;

        private readonly IWordRepository _wordRepository;

        public WordService(
            IMapper mapper,
            IWordQueryFactory wordFactory,
            IWordRepository wordRepository)
        {
            _mapper = mapper;
            _wordFactory = wordFactory;
            _wordRepository = wordRepository;
        }

        public async Task<List<WordModel>> GetWords(
            LanguageType languageType,
            CategoryType categoryType,
            int maxLength = int.MaxValue)
        {
            try
            {
                var languageQuery = _wordFactory
                    .CreateLanguageQuery(languageType);

                var categoryQuery = _wordFactory
                    .CreateCategoryQuery(categoryType);

                var result = await _wordRepository.QueryAsync(
                    languageQuery,
                    categoryQuery);

                var words = _mapper
                    .Map<IEnumerable<WordModel>>(result[0])
                    .Where(word => word.Value.Length <= maxLength)
                    .ToList();

                return words;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<WordModel>>(
                    ex.InnerException);
            }
        }
    }
}
