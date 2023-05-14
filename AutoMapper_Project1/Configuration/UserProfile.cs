using AutoMapper;
using AutoMapper_Project1.DTOs;
using AutoMapper_Project1.Models;

namespace AutoMapper_Project1.Configuration
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            //source mapping to destination
            CreateMap<User, UserDto>()
                .ForMember(destinationMember => destinationMember.UserId, opt => opt.MapFrom(src => src.Id))
                .ForMember(destinationMember => destinationMember.UserName, opt => opt.MapFrom(src => src.Name))
                .ForMember(destinationMember => destinationMember.UserAge, opt => opt.MapFrom(src => src.Age))
                .ReverseMap()
                .ForMember(srcMember => srcMember.Id, destMember => destMember.MapFrom(des => des.UserId))
                .ForMember(srcMember => srcMember.Name, destMember => destMember.MapFrom(des => des.UserName))
                .ForMember(srcMember => srcMember.Age, destMember => destMember.MapFrom(des => des.UserAge));

        }
    }
}
