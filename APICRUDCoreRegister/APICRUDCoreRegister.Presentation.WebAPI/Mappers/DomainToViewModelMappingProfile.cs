using APICRUDCoreRegister.Domain.Domain.Models;
using APICRUDCoreRegister.Presentation.WebAPI.Models.Return;

namespace APICRUDCoreRegister.Presentation.WebAPI.Mappers
{
    public class DomainToViewModelMappingProfile : AutoMapper.Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserReturnVM>();
        }
    }
}
