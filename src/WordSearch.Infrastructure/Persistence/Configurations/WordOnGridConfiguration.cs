using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordSearch.Common.Constants;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.Configurations
{
    public class WordOnGridConfiguration : IEntityTypeConfiguration<WordOnGrid>
    {
        public void Configure(EntityTypeBuilder<WordOnGrid> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Word).HasMaxLength(LengthValidatorConstant.Word).IsRequired();
            builder.Property(x => x.IsFound).IsRequired();

            builder.HasOne(x => x.WordSet)
                .WithMany()
                .HasForeignKey(x => x.WordSetId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.WordDirection)
                .WithMany()
                .HasForeignKey(x => x.WordDirectionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.GameSession)
                .WithMany(x => x.WordsOnGrid)
                .HasForeignKey(x => x.GameSessionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
