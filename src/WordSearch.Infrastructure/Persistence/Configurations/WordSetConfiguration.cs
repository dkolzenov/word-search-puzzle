using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordSearch.Domain.Entities;
using WordSearch.Infrastructure.Persistence.SeedData;

namespace WordSearch.Infrastructure.Persistence.Configurations
{
    public class WordSetConfiguration : IEntityTypeConfiguration<WordSet>
    {
        public void Configure(EntityTypeBuilder<WordSet> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Words).IsRequired();
            builder.Property(x => x.Category).IsRequired();
            builder.Property(x => x.Language).IsRequired();
            builder.HasIndex(x => x.Words).IsUnique();
            builder.HasData(WordSetSeedData.Get());
        }
    }
}
