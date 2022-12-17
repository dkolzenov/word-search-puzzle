using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordSearch.Domain.Entities;
using WordSearch.Infrastructure.Persistence.SeedData;

namespace WordSearch.Infrastructure.Persistence.Configurations
{
    public class WordDirectionConfiguration : IEntityTypeConfiguration<WordDirection>
    {
        public void Configure(EntityTypeBuilder<WordDirection> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.RowMovement).IsRequired();
            builder.Property(x => x.ColumnMovement).IsRequired();
            builder.Property(x => x.LayoutType).HasConversion<string>().IsRequired();
            builder.Property(x => x.DirectionType).HasConversion<string>().IsRequired();
            builder.HasIndex(x => x.DirectionType).IsUnique();
            builder.HasData(WordDirectionSeedData.Get());
        }
    }
}
