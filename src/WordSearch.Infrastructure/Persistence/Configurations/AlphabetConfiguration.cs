using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordSearch.Common.Constants;
using WordSearch.Domain.Entities;
using WordSearch.Infrastructure.Persistence.SeedData;

namespace WordSearch.Infrastructure.Persistence.Configurations
{
    public class AlphabetConfiguration : IEntityTypeConfiguration<Alphabet>
    {
        public void Configure(EntityTypeBuilder<Alphabet> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Characters).HasMaxLength(LengthValidatorConstant.Name).IsRequired();
            builder.Property(x => x.Script).HasMaxLength(LengthValidatorConstant.Name).IsRequired();
            builder.HasIndex(x => new { x.Characters, x.Script }).IsUnique();
            builder.HasData(AlphabetSeedData.Get());
        }
    }
}
