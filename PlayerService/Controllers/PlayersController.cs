using PlayerService.Models;

using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PlayerService.Data;
using PlayerService.Dtos;
using PlayerService.SyncDataServices.Http;

namespace PlayerService.Contollers {
    
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase {
        private readonly IPlayerRepo _repository;
        private readonly IMapper _mapper;
        private readonly IPlayerDataClient _playerDataClient;
        public PlayersController(IPlayerRepo repository, IMapper mapper,
        IPlayerDataClient playerDataClient) {
            _repository = repository;
            _mapper = mapper;
            _playerDataClient = playerDataClient;
        }
        [HttpGet]
        public ActionResult<IEnumerable<PlayerReadDto>> GetPlayers() {
            Console.WriteLine("--> Getting Players...");

            var playerItem = _repository.GetAllPlayers();
            return Ok(_mapper.Map<IEnumerable<PlayerReadDto>>(playerItem));
        }

        // Give name (same as method signature) for route
        [HttpGet("{id}", Name="GetPlayerById")]
        public ActionResult<PlayerReadDto> GetPlayerById(int id) {
            var playerItem = _repository.GetPlayerById(id);
            if (playerItem != null) {
                return Ok(_mapper.Map<PlayerReadDto>(playerItem));
            } else {
                // href = Url.Link(nameof(GetPlayerById))
                return NotFound();
            }
        }

        // Successful create for REST --> return 201 code + resource object + URI

        //return 201 w/ the route (AKA URI)
        [HttpPost]
        public async Task<ActionResult<PlayerReadDto>> CreatePlayer(PlayerCreateDto playerCreateDto) {
            var playerModel = _mapper.Map<Player>(playerCreateDto);
            _repository.CreatePlayer(playerModel);
            _repository.SaveChanges();

            var playerReadDto = _mapper.Map<PlayerReadDto>(playerModel);

            try {
                await _playerDataClient.SendPlayerToScouting(playerReadDto);
            } catch(Exception ex) {
                Console.WriteLine($"--> Could not send synchronously: {ex.Message}");
            }

            return CreatedAtRoute(nameof(GetPlayerById), new {Id=playerReadDto.Id}, playerReadDto);
        }
    }
}