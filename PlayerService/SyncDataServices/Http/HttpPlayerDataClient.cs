
using System.Text;
using System.Text.Json;

using PlayerService.Dtos;

namespace PlayerService.SyncDataServices.Http
{      
       
          public class HttpPlayerDataClient : IPlayerDataClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public HttpPlayerDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }


        public async Task SendPlayerToScouting(PlayerReadDto plat)
        {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(plat),
                Encoding.UTF8,
                "application/json");

            Console.WriteLine($"{_configuration["PlayersService"]}api/c/players");
            var response = await _httpClient.PostAsync($"{_configuration["PlayersService"]}api/c/players", httpContent);
            //var response = await _httpClient.PostAsync("1", httpContent);
            Console.WriteLine($"{_configuration["PlayersService"]}api/c/players");
            
            

            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine("--> Sync POST to CommandService was OK!");
            }
            else
            {
                Console.WriteLine("--> Sync POST to CommandService was NOT OK!");
            }
        }


    }
  
}