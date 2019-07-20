using APICRUDCoreRegister.Domain.Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using APICRUDCoreRegister.Infra.Data.MYSQL.Repositories;

namespace APICRUDCoreRegister.Infra.CrossCutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            #region Repositories 
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion
        }
    }
}
