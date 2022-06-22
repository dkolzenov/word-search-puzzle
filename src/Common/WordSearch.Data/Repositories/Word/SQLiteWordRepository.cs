namespace WordSearch.Data.Repositories.Word
{
    using System;
    using System.IO;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SQLite;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Assets.Databases.Constants;
    using WordSearch.Models.Word;
    using WordSearch.Helpers.Interfaces;

    public class SQLiteWordRepository : IWordRepository
    {
        private readonly SQLiteAsyncConnection _database;

        public SQLiteWordRepository(IPlatformPathHelper pathHelper)
        {
            _database = new SQLiteAsyncConnection(
                Path.Combine(pathHelper.Path, new WordsDbConstant().Name));
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
                return await Task.FromException<List<WordModel>>(
                    ex.InnerException);
            }
        }

        public async Task<bool> Add(WordModel wordModel)
        {
            try
            {
                var taskResult = _database.InsertAsync(wordModel).IsCompleted;

                return taskResult;
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
                var taskResult = _database.UpdateAsync(wordModel).IsCompleted;

                return taskResult;
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
                var taskResult = _database.DeleteAsync(wordModel).IsCompleted;

                return taskResult;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex.InnerException);
            }
        }

        public async Task<List<WordModel>> QueryWords(
            params Expression<Func<WordModel, bool>>[] predicates)
        {
            try
            {
                var result = _database.Table<WordModel>();

                foreach (var predicate in predicates)
                    result = result.Where(predicate);

                return await result.ToListAsync();
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<WordModel>>(
                    ex.InnerException);
            }
        }
    }
}
