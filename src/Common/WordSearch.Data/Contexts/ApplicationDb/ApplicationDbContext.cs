namespace WordSearch.Data.Contexts.ApplicationDb
{
    using Microsoft.EntityFrameworkCore;

    using WordSearch.Data.Entities.Word;
    using WordSearch.Data.Entities.Character;
    using WordSearch.Data.Entities.Grid;
    using WordSearch.Data.Entities.Difficulty;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<WordEntity> Words { get; set; } = null!;

        public DbSet<CharacterEntity> Characters { get; set; } = null!;

        public DbSet<GridEntity> Grids { get; set; } = null!;

        public DbSet<DifficultyEntity> Difficulties { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
