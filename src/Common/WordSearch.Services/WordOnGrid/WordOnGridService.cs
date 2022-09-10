namespace WordSearch.Services.WordOnGrid
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.WordOnGrid;
    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Entities.WordOnGrid;

    public class WordOnGridService : IWordOnGridService
    {
        private readonly IMapper _mapper;

        private readonly IWordOnGridRepository _wordOnGridRepository;

        public WordOnGridService(
            IMapper mapper,
            IWordOnGridRepository wordOnGridRepository)
        {
            _mapper = mapper;
            _wordOnGridRepository = wordOnGridRepository;
        }

        public async Task<List<WordOnGridModel>> GetAllWordsOnGridAsync()
        {
            try
            {
                List<WordOnGridEntity> result = await _wordOnGridRepository
                    .GetAllAsync();

                var wordsOnGrid = _mapper.Map<List<WordOnGridModel>>(result);

                return wordsOnGrid;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<WordOnGridModel>>(ex);
            }
        }

        public async Task<WordOnGridModel> AddWordOnGridAsync(
            WordOnGridModel wordOnGrid)
        {
            try
            {
                var wordOnGridEntity = _mapper
                    .Map<WordOnGridEntity>(wordOnGrid);

                WordOnGridEntity result = await _wordOnGridRepository
                    .AddAsync(wordOnGridEntity);

                var addedWordOnGrid = _mapper.Map<WordOnGridModel>(result);

                return addedWordOnGrid;
            }
            catch (Exception ex)
            {
                return await Task.FromException<WordOnGridModel>(ex);
            }
        }

        public async Task<WordOnGridModel> RemoveWordOnGridAsync(
            WordOnGridModel wordOnGrid)
        {
            try
            {
                var wordOnGridEntity = _mapper
                    .Map<WordOnGridEntity>(wordOnGrid);

                WordOnGridEntity result = await _wordOnGridRepository
                    .RemoveAsync(wordOnGridEntity);

                var removedWordOnGrid = _mapper.Map<WordOnGridModel>(result);

                return removedWordOnGrid;
            }
            catch (Exception ex)
            {
                return await Task.FromException<WordOnGridModel>(ex);
            }
        }
    }
}
