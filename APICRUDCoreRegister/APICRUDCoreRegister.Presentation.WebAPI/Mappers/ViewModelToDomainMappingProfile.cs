using APICRUDCoreRegister.Presentation.WebAPI.Models.VM;
using APICRUDCoreRegister.Domain.Domain.Models;

namespace APICRUDCoreRegister.Presentation.WebAPI.Mappers
{
    public class ViewModelToDomainMappingProfile : AutoMapper.Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserPostVM, User>();
            CreateMap<UserPutVM, User>();
            CreateMap<UserGetVM, UserGet>();
            CreateMap<UserDeleteVM, User>();
        }
    }
}
