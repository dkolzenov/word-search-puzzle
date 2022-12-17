using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WordSearch.Application.Common.Interfaces;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Alphabet> Alphabets { get; set; } = null!;

        public DbSet<WordSet> WordSets { get; set; } = null!;

        public DbSet<CharacterOnGrid> CharactersOnGrid { get; set; } = null!;

        public DbSet<GameSession> GameSessions { get; set; } = null!;

        public DbSet<GameSessionSettings> GameSessionSettings { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
