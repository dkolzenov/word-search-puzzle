using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordSearch.Domain.Entities;
using WordSearch.Infrastructure.Persistence.SeedData;

namespace WordSearch.Infrastructure.Persistence.Configurations
{
    public class GameSessionSettingsConfiguration : IEntityTypeConfiguration<GameSessionSettings>
    {
        public void Configure(EntityTypeBuilder<GameSessionSettings> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Difficulty).HasConversion<string>().IsRequired();
            builder.HasData(GameSessionSettingsSeedData.Get());

            builder.HasOne(x => x.GridSettings)
                .WithMany()
                .HasForeignKey(x => x.GridSettingsId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
