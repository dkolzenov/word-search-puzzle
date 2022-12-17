using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WordSearch.Domain.Entities;

namespace WordSearch.Application.Common.Interfaces
{
    public interface IApplicationDbContext : IDisposable, IScopedService
    {
        public DbSet<Alphabet> Alphabets { get; }
        
        public DbSet<WordSet> WordSets { get; }
        
        public DbSet<CharacterOnGrid> CharactersOnGrid { get; }
        
        public DbSet<GameSession> GameSessions { get; }
        
        public DbSet<GameSessionSettings> GameSessionSettings { get; }

        public DatabaseFacade Database { get; }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        int SaveChanges();
    }
}
