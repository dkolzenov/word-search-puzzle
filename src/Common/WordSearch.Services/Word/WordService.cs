namespace WordSearch.Services.Word
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Services.Word.Factories.Interfaces;
    using WordSearch.Services.Word.Enums;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Word;

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
            CategoryType categoryType)
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

                var words = _mapper.Map<List<WordModel>>(result);

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
