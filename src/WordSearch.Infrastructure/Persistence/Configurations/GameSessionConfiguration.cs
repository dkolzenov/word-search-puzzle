using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.Configurations
{
    public class GameSessionConfiguration : IEntityTypeConfiguration<GameSession>
    {
        public void Configure(EntityTypeBuilder<GameSession> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.GameSessionSettings)
                .WithMany()
                .HasForeignKey(x => x.GameSessionSettingsId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
