namespace WordSearch.Data.Repositories.Word
{
    using System;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SQLite;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Database.Constants;
    using WordSearch.Models.Word;
    using WordSearch.Helpers.Interfaces;

    public class SQLiteWordRepository : IWordRepository
    {
        private readonly SQLiteAsyncConnection _database;

        public SQLiteWordRepository(IDatabasePathHelper dbPathHelper)
        {
            _database = new SQLiteAsyncConnection(
                dbPathHelper.GetDatabasePath(WordsDatabaseConstants.DbName));
        }

        public async Task<List<WordModel>> Get()
        {
            try
            {
                var words = await _database.Table<WordModel>().ToListAsync();
                return words;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<WordModel>>(ex.InnerException);
            }
        }

        public async Task<bool> Add(WordModel wordModel)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex.InnerException);
            }
        }

        public async Task<bool> Update(WordModel wordModel)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex.InnerException);
            }
        }

        public async Task<bool> Remove(WordModel wordModel)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex.InnerException);
            }
        }

        public async Task<List<WordModel>> QueryWords(
            Expression<Func<WordModel, bool>> predicate)
        {
            try
            {
                var words = await _database.Table<WordModel>()
                    .Where(predicate)
                    .ToListAsync();

                return words;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<WordModel>>(ex.InnerException);
            }
        }

        public async Task<List<WordModel>> GetWords(string language, string category)
        {
            var wordList = await QueryWords(
                words => words.Category == category &&
                words.Language == language);

            return wordList;
        }
    }
}
