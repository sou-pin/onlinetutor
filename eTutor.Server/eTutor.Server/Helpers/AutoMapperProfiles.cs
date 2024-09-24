using AutoMapper;
using eTutor.DataService.Models;
using eTutor.Server.DTO;

namespace eTutor.Server.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<RegisterDto, User>();
        }
    }
}
