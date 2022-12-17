using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordSearch.Domain.Entities;
using WordSearch.Infrastructure.Persistence.SeedData;

namespace WordSearch.Infrastructure.Persistence.Configurations
{
    public class WordOnGridSettingsConfiguration : IEntityTypeConfiguration<WordOnGridSettings>
    {
        public void Configure(EntityTypeBuilder<WordOnGridSettings> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.WordCount).IsRequired();
            builder.Property(x => x.WordLength).IsRequired();
            builder.HasData(WordOnGridSettingsSeedData.Get());

            builder.HasOne(x => x.GameSessionSettings)
                .WithMany(x => x.WordOnGridSettingsList)
                .HasForeignKey(x => x.GameSessionSettingsId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
