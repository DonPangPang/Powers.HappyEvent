using Microsoft.EntityFrameworkCore;

namespace Powers.HappyEvent.WebApi.Data
{
    public class HappyEventDbContext : DbContext
    {
        public HappyEventDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
