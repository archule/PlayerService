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

//15a1153c48fa5b3971a7beb8ca409f4055975beddb3902e752221e71ce90225f