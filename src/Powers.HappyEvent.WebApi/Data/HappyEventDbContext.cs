using Microsoft.EntityFrameworkCore;
using Powers.HappyEvent.Shared;
using Powers.HappyEvent.WebApi.Extensions;

namespace Powers.HappyEvent.WebApi.Data
{
    public class HappyEventDbContext : DbContext
    {
        public HappyEventDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddEntityTypes();

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
