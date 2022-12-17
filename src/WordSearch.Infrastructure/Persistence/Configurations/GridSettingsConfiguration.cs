using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence.Configurations
{
    public class GridSettingsConfiguration : IEntityTypeConfiguration<GridSettings>
    {
        public void Configure(EntityTypeBuilder<GridSettings> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.RowCount).IsRequired();
            builder.Property(x => x.ColumnCount).IsRequired();
        }
    }
}
