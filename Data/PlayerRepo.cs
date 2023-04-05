using PlayerService.Models;

namespace PlayerService.Data
{
    public class PlayerRepo : IPlayerRepo
    {
        private readonly AppDbContext _context;

        public PlayerRepo(AppDbContext context) {
            // _ fo private field
            _context = context;
        }
        public void CreatePlayer(Player player)
        {
            if(player == null) {
                throw new ArgumentNullException(nameof(player));
            }
            _context.Players.Add(player);
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return _context.Players.ToList();
        }

        public Player GetPlayerById(int id)
        {
            return _context.Players.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() <= 0);
        }
    }
}