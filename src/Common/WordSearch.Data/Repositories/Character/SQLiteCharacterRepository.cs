namespace WordSearch.Data.Repositories.Character
{
    using System;
    using System.IO;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using SQLite;

    using WordSearch.Data.Repositories.Interfaces;
    using WordSearch.Data.Database.Constants;
    using WordSearch.Models.Character;
    using WordSearch.Helpers.Interfaces;

    public class SQLiteCharacterRepository : ICharacterRepository
    {
        private readonly SQLiteAsyncConnection _database;

        public SQLiteCharacterRepository(IPlatformPathHelper pathHelper)
        {
            _database = new SQLiteAsyncConnection(
                Path.Combine(pathHelper.Path, CharactersDbConstants.Name));
        }

        public async Task<List<CharacterModel>> Get()
        {
            try
            {
                var characters = await _database.Table<CharacterModel>()
                    .ToListAsync();

                return characters;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<CharacterModel>>(
                    ex.InnerException);
            }
        }

        public async Task<bool> Add(CharacterModel characterModel)
        {
            try
            {
                var taskResult = _database.InsertAsync(characterModel)
                    .IsCompleted;

                return taskResult;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex.InnerException);
            }
        }

        public async Task<bool> Update(CharacterModel characterModel)
        {
            try
            {
                var taskResult = _database.UpdateAsync(characterModel)
                    .IsCompleted;

                return taskResult;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex.InnerException);
            }
        }

        public async Task<bool> Remove(CharacterModel characterModel)
        {
            try
            {
                var taskResult = _database.DeleteAsync(characterModel)
                    .IsCompleted;

                return taskResult;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex.InnerException);
            }
        }

        public async Task<List<CharacterModel>> QueryCharacters(
            params Expression<Func<CharacterModel, bool>>[] predicates)
        {
            try
            {
                var result = _database.Table<CharacterModel>();

                foreach (var predicate in predicates)
                    result = result.Where(predicate);

                return await result.ToListAsync();
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<CharacterModel>>(
                    ex.InnerException);
            }
        }
    }
}
