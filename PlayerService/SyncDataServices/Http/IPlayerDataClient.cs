using System.Text;
using System.Text.Json;
using PlayerService.Dtos;

namespace PlayerService.SyncDataServices.Http {
    public interface IPlayerDataClient {
        Task SendPlayerToScouting(PlayerReadDto play);
    }

 
}