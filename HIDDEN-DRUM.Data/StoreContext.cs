using HIDDEN_DRUM.Domain;
using Microsoft.EntityFrameworkCore;

namespace HIDDEN_DRUM.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }

        public DbSet<Timer> Items { get; set; }  // Use concrete class instead of interface

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}



