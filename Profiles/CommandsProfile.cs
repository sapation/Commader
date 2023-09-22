
using AutoMapper;
using Dtos;
using Models;

namespace Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //source -> target
            CreateMap<Command, CommandReadDtos>();

            //target -> sourec
            CreateMap<CommandCreateDto, Command>();

            //update map
            CreateMap<CommandUpdateDto, Command>();

            //patch map
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}