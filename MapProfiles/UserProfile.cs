using AutoMapper;
using AutoMapperExample.DTO;
using AutoMapperExample.Models;

namespace AutoMapperExample.MapProfiles;

public class UserProfile : Profile
{
    public UserProfile()
	{
		CreateMap<User, UserDTO>()
        .ForMember(destinationMember => destinationMember.Name, options => options.MapFrom(sourceMember => sourceMember.Name))
        .ForMember(destinationMember => destinationMember.Status, options => options.MapFrom(sourceMember => ((UserStatus)sourceMember.Status).ToString()));
	}
}