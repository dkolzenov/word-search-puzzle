namespace WordSearch.Data.Contexts.ApplicationDb
{
    using Microsoft.EntityFrameworkCore;

    using WordSearch.Data.Entities.Word;
    using WordSearch.Data.Entities.Character;
    using WordSearch.Data.Entities.Grid;
    using WordSearch.Data.Entities.GameSettings;
    using WordSearch.Data.Entities.Direction;
    using WordSearch.Data.Entities.WordOnGrid;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<WordEntity> Words { get; set; } = null!;

        public DbSet<CharacterEntity> Characters { get; set; } = null!;

        public DbSet<GridEntity> Grids { get; set; } = null!;

        public DbSet<GameSettingsEntity> GameSettings { get; set; } = null!;

        public DbSet<DirectionEntity> Directions { get; set; } = null!;

        public DbSet<WordOnGridEntity> WordOnGrid { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
