using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordSearch.Common.Constants;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.Configurations
{
    public class CharacterOnGridConfiguration : IEntityTypeConfiguration<CharacterOnGrid>
    {
        public void Configure(EntityTypeBuilder<CharacterOnGrid> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Character).HasMaxLength(LengthValidatorConstant.Character).IsRequired();
            builder.Property(x => x.Row).IsRequired();
            builder.Property(x => x.Column).IsRequired();

            builder.HasOne(x => x.Alphabet)
                .WithMany()
                .HasForeignKey(x => x.AlphabetId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.WordOnGrid)
                .WithMany()
                .HasForeignKey(x => x.WordOnGridId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.GameSession)
                .WithMany(x => x.CharactersOnGrid)
                .HasForeignKey(x => x.GameSessionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
