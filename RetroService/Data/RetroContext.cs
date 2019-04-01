using Microsoft.EntityFrameworkCore;
using RetroService.Models;

namespace RetroService.Data
{
    public class RetroContext : DbContext
    {
        public RetroContext(DbContextOptions<RetroContext> options) : base(options) { }

        public DbSet<Board> Boards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Board>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        }
    }
}
