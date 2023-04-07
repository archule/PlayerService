using AutoMapper;
using PlayerService.Dtos;
using PlayerService.Models;

namespace PlayerService.PlayrProfiles {
    public class PlayersProfile : Profile {
        public PlayersProfile()
        {
            CreateMap<Player, PlayerReadDto>();
            CreateMap<PlayerCreateDto, Player>();
        }
    }
}