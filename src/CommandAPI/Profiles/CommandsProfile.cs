using AutoMapper;
using CommandAPI.Dtos;
using CommandAPILibrary.Models;
namespace CommandAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto> ();
        }
    }
}