namespace WordSearch.Services.WordOnGrid
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using AutoMapper;

    using WordSearch.Services.Interfaces;
    using WordSearch.Models.WordOnGrid;

    public class WordOnGridService : IWordOnGridService
    {
        private readonly IMapper _mapper;

        public WordOnGridService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<List<WordOnGridModel>> GetWordsOnGridAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<WordOnGridModel> AddWordOnGridAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
