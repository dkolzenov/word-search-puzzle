namespace WordSearch.Services.Word
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Models.Word;
    using WordSearch.Core.Enums.Word;

    public class WordService : IWordService
    {
        private readonly IMapper _mapper;

        private readonly IWordRepository _wordRepository;

        public WordService(
            IMapper mapper,
            IWordRepository wordRepository)
        {
            _mapper = mapper;
            _wordRepository = wordRepository;
        }

        public async Task<List<WordModel>> GetWordsAsync(
            LanguageType languageType,
            CategoryType categoryType,
            int maxLength = int.MaxValue)
        {
            try
            {
                var result = await _wordRepository
                    .GetWordsAsync(languageType, categoryType);

                var words = _mapper
                    .Map<IEnumerable<WordModel>>(result)
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
