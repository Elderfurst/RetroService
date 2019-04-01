using Microsoft.EntityFrameworkCore;
using RetroService.Models;

namespace RetroService.Data
{
    public class RetroContext : DbContext
    {
        public RetroContext(DbContextOptions<RetroContext> options) : base(options) { }

        public DbSet<Board> Boards { get; set; }
    }
}
