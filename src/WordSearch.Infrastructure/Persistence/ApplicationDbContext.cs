using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WordSearch.Application.Common.Interfaces;
using WordSearch.Domain.Entities;

namespace WordSearch.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Alphabet> Alphabets { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
