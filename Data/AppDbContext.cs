using Microsoft.EntityFrameworkCore;
using PlayerService.Models;

namespace PlayerService.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) {

        }

        // DB set for the player table
        public DbSet<Player> Players {get; set;}
    }
}