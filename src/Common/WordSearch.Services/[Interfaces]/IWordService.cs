﻿namespace WordSearch.Services.Interfaces
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using WordSearch.Models.Word;
    using WordSearch.Core.Enums.Word;

    public interface IWordService
    {
        Task<List<WordModel>> GetWords(
            LanguageType languageType,
            CategoryType categoryType,
            int maxLength = int.MaxValue);
    }
}
