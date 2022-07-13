namespace WordSearch.Data.Contexts.ApplicationDb
{
    using Microsoft.EntityFrameworkCore;

    using WordSearch.Data.Entities.Word;
    using WordSearch.Data.Entities.Character;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<WordEntity> Words { get; set; } = null!;

        public DbSet<CharacterEntity> Characters { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
