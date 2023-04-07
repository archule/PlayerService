using PlayerService.Models;

namespace PlayerService.Data
{
    public interface IPlayerRepo {
        bool SaveChanges();

        IEnumerable<Player> GetAllPlayers();
        Player GetPlayerById(int id);
        void CreatePlayer(Player player);

    }


}