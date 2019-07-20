using APICRUDCoreRegister.Domain.Domain.Interfaces.Repositories;
using APICRUDCoreRegister.Domain.Domain.Models;
using APICRUDCoreRegister.Infra.Data.MSSQL.Context;
using System.Collections.Generic;
using System.Linq;

namespace APICRUDCoreRegister.Infra.Data.MYSQL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        DBContext ctx;
        public UserRepository(DBContext ctx) : base(ctx)
        {
            this.ctx = ctx;
        }        

        public bool ExistsProfile(int idProfile)
        {
            return ctx.Profiles.Where(w => w.idProfile == idProfile).Any();
        }

        public List<User> Get(UserGet user)
        {
            return ctx.Users.Where(w =>
            (user.idUser == null || w.idUser == user.idUser) &&
            (user.idProfile == null || w.idProfile == user.idProfile) &&
            (user.name == null || w.name.ToUpper().Contains(user.name.ToUpper())) &&
            (user.email == null || w.email.ToUpper().Contains(user.email.ToUpper())) &&
            (user.isActive == null || w.isActive == user.isActive)
            ).OrderBy(o => o.idUser).ToList();
        }
    }
}
