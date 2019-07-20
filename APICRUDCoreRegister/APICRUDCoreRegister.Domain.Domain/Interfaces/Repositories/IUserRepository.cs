using APICRUDCoreRegister.Domain.Domain.Models;
using System.Collections.Generic;

namespace APICRUDCoreRegister.Domain.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        bool ExistsProfile(int idProfile);
        List<User> Get(UserGet user);
    }
}
